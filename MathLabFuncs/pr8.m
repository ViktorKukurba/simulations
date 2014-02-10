function dy=pr8(x,y)
dy=zeros(2,1);
dy(1)=y(2);
dy(2)=((y(1)/x)-y(2))*(1/x)-y(1);
end