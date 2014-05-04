function [time,value] = MLV(t,x,a,b,c,d)
[time,value] = ode45(@MLVSolver,t,x);
function f=MLVSolver(t,x)
f=[(1/t)*(a*x(1)-b*x(1)*x(2));
   -(1/t)*(d*x(2)+c*x(1)*x(2))];
end
end