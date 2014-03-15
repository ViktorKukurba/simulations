import sys
sys.path.append(r'c:\Program Files\IronPython 2.7')
sys.path.append(r'c:\Program Files\IronPython 2.7\DLLs')
sys.path.append(r'c:\Program Files\IronPython 2.7\Lib')
sys.path.append(r'c:\Program Files\IronPython 2.7\Lib\site-packages')

#import clr
#clr.AddReference('mtrand.dll')
import numpy as np
import scipy
from scipy.integrate import odeint
print np.__version__
print scipy.__version__
def Solve():
# Definition of parameters
	import pylab as p
	t = np.linspace(0, 15,  100) # time
	X0 = np.array([100, 5])        # initials conditions: 10 rabbits and 5 foxes
	print t
	X, infodict = odeint(dX_dt, X0, t, full_output=True)
	infodict['message']
	rabbits, foxes = X.T
	print rabbits
	f1 = p.figure()
	p.plot(t, rabbits, 'r-', label='Rabbits')
	p.plot(t, foxes  , 'b-', label='Foxes')
	p.grid()
	p.legend(loc='best')
	p.xlabel('time')
	p.ylabel('population')
	p.title('Evolution of fox and rabbit populations')
	f1.savefig('LV_1.png') 
	return X.T

def dX_dt(X, t=0):
# Definition of parameters
	a = 1.
	b = 0.1
	c = 1.5
	d = 0.75
	""" Return the growth rate of fox and rabbit populations. """
	return np.array([ a*X[0] -   b*X[0]*X[1] , -c*X[1] + d*b*X[0]*X[1] ])

Solve()