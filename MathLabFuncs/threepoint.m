function f=threepoint(t,x)
M1=50; M2=0; C1x=5; C1y=0; C2x=0; C2y=10;
f=[x(3);x(4);
-M1*(x(1)-C1x)/(sqrt((x(1)-C1x)^2+(x(2)-C1y)^2))^3-M2*(x(1)-C2x)/(sqrt((x(1)-C2x)^2+(x(2)-C2y)^2))^3;
-M1*(x(2)-C1y)/(sqrt((x(1)-C1x)^2+(x(2)-C1y)^2))^3-M2*(x(2)-C2y)/(sqrt((x(1)-C2x)^2+(x(2)-C2y)^2))^3];
end