%my local plan for chapter 2 is:
%1. To get to the Fourier transform step by step
%2. Deal with the pyramids

%close all;
pi = 3.14;
exp = 2.718;

M = 15;
N = 15;

M_mid = floor(M/2) + 1;
N_mid = floor(N/2) + 1;

sigma = 2;

z = zeros(M, N);

for x=1:M
    for y=1:N
        z(x,y) = (1/(2*pi*sigma^2))*exp^(-((x-M_mid)^2 + (y-N_mid)^2)/(2*sigma^2));
    end
end

[zGradX, zGradY] = gradient(z);

%We created a Gaussian and found its gradient. 
%Now create the smoothed directional derivative filter

alfa = 160;

% u component of U vector
u = cosd(alfa);

% v component of U vector
v = sind(alfa);

zResult = z;

for x=1:M
    for y=1:N
        zResult(x,y) = u*zGradX(x,y) + v*zGradY(x,y);
    end
end

%figure('Name','Initial gaussian','NumberTitle','off')
%mesh(z)
%figure('Name','X','NumberTitle','off')
%mesh(zGradX)
%figure('Name','Y','NumberTitle','off')
%mesh(zGradY)
%figure('Name','The smoothed directional derivative filter','NumberTitle','off')
mesh(zResult)

zResult
