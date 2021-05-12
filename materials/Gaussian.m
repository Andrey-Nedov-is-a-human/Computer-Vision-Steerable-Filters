tt = 1:0.1:1*pi;
pi = 3.14;
exp = 2.718;

sigma = 10;

x = zeros(1, length(tt));
v = randn(1, length(tt));

for i=1:length(tt)
    x(i) = 10*sin(tt(i)) + v(i);
end

g = x;
a = 1;

for i=1:length(tt)
    %g(i) = (1/(sqrt(2*pi)*sigma))*exp^(-(tt(i)^2)/(2*sigma^2));
    g(i) = sqrt(a/pi)*exp^(-a*tt(i)^2);
end

plot(tt, x, 'r', tt, g, 'g')

