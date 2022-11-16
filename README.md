# Visualization of a steerable filter using MathLab

*Developer*
1. [Andrey Nedov](github.com/Andrey-Nedov)

## A rotating filter

[Full paper](https://github.com/Andrey-Nedov/Computer-Vision-Steerable-Filters/tree/main/materials/Steerable_filter_Report.pdf)

1. We take the function of a two-dimensional normal distribution

<img src="/imgs/img2.jpg" width="300"/>

2. Extract the *Gx* and *Gy* components of the function gradient

3. Obtaining a directional filter of the directional derivative
 
<img src="/imgs/img3.jpg" width="220"/>

where

<img src="/imgs/img4.jpg" width="260"/>

## Implementation in MathLab

By changing the angle *θ* we can change the direction of the filter.

<img src="/imgs/img1.png" width="700"/>


