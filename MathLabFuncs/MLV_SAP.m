function [time,value] = MLV_SAP(t,x,a,b,c,d,alpha)
[time,value] = ode45(@MLVSAPSolver,t,x);
function f=MLVSAPSolver(t,x)
    f=[(alpha/t)*(a*x(1)-b*x(1)*x(2));
   (alpha/t)*(-d*x(2)+c*x(1)*x(2))];
end
end