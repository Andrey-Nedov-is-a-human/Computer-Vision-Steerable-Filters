function output = factorial_function(size_in, sigma_in, angle_in)

    %my local plan for chapter 2 is:
%1. To get to the Fourier transform step by step
%2. Deal with the pyramids

%close all;
pi = 3.14;
exp = 2.718;

M = size_in;
N = size_in;

M_mid = floor(M/2) + 1;
N_mid = floor(N/2) + 1;

sigma = sigma_in;

z = zeros(M, N);

for x=1:M
    for y=1:N
        z(x,y) = (1/(2*pi*sigma^2))*exp^(-((x-M_mid)^2 + (y-N_mid)^2)/(2*sigma^2));
    end
end

[zGradX, zGradY] = gradient(z);

%We created a Gaussian and found its gradient. 
%Now create the smoothed directional derivative filter

alfa = angle_in;

% u component of U vector
u = cosd(alfa);

% v component of U vector
v = sind(alfa);

zGrad = z;

for x=1:M
    for y=1:N
        zGrad(x,y) = u*zGradX(x,y) + v*zGradY(x,y);
    end
end

mesh(zGrad)
output = zGrad;
%mesh(z)
%output = z

end