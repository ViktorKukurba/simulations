from numpy import *
import pylab as p
# Definition of parameters
a = 1.
b = 1
c = 1
d = 1
def dX_dt(X, t=0):
	""" Return the growth rate of fox and rabbit populations. """
	return array([(a*X[0] -   b*X[0]*X[1]) ,
                    (-c*X[1] + d*b*X[0]*X[1])])

from scipy import integrate
t = linspace(0, 1500,  100)              # time
#print t
X0 = array([2, 3])                     # initials conditions: 10 rabbits and 5 foxes
X, infodict = integrate.odeint(dX_dt, X0, t, full_output=True)
infodict['message']
#print infodict
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
f1.savefig('rabbits_and_foxes_1.png') 