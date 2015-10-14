import sys
sys.path.append(r'c:\Program Files\IronPython 2.7')
sys.path.append(r'c:\Program Files\IronPython 2.7\DLLs')
sys.path.append(r'c:\Program Files\IronPython 2.7\Lib')
sys.path.append(r'c:\Program Files\IronPython 2.7\Lib\site-packages')

import clr
clr.AddReference('mtrand.dll')
import numpy as np
import scipy
print np.__version__
print scipy.__version__


def Simple(param1):
	print "Hello from Python"
	print "Call Dir(): "
	print dir()
	print "Print the Path: " 
	print sys.path
	return param1+2

from scipy.integrate import odeint

 
def deriv(y,t):
	yprime = np.array([3.5*y[0]])
	return yprime

def Solver2():
	start=0
	end=1
	numsteps=1000
	time=np.linspace(start,end,numsteps)
	y0=np.array([10])
	y=scipy.integrate.odeint(deriv,y0,time)
	return y

def fun(y, t, a):
    """Define the right-hand side of equation dy/dt = a*y""" 
    f = a
    return f

def Solver():
	# Initial condition
	y0 = 100.0

	# Times at which the solution is to be computed.
	t = np.linspace(0, 1, 51)

	# Parameter value to use in `fun`.
	a = -2.5

	# Solve the equation.
	y = odeint(fun, y0, t, args=(a,))
	return y

from numpy import *
#import pylab as p
from scipy import integrate

#def LotkaVolterra(start, end, a, b, c, d, nStart, pStart):
def LotkaVolterra():
	# Definition of parameters
	a = 1.
	b = 1
	c = 1
	d = 1

	def dX_dt(X, t=1):
		""" Return the growth rate of fox and rabbit populations. """
		return array([ a*X[0] -   b*X[0]*X[1] , -c*X[1] + d*b*X[0]*X[1] ])

	print 'start'
	print 'start-2'

	t = linspace(0, 15000,  1000)              # time
	X0 = array([2, 3])                     # initials conditions: 10 rabbits and 5 foxes
	print 't-2'
	X, infodict = integrate.odeint(dX_dt, X0, t, full_output=True)
	print 't-3'

	#print X
	infodict['message']
	rabbits, foxes = X.T

	print rabbits
	#f1 = p.figure()
	#p.plot(t, rabbits, 'r-', label='Rabbits')
	#p.plot(t, foxes  , 'b-', label='Foxes')
	#p.grid()
	#p.legend(loc='best')
	#p.xlabel('time')
	#p.ylabel('population')
	#p.title('Evolution of fox and rabbit populations')
	#f1.savefig('test.png')

	print foxes
	return t, rabbits, foxes

#LotkaVolterra()
