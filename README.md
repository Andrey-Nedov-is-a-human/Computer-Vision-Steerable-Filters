# Визуализация поворачивающегося ядра свертки в MathLab / Visualization of a steerable filter using MathLab

*Разработчик/Developer*
1. [Андрей Недов](github.com/Andrey-Nedov-is-a-human)

## Построение поворачивающегося фильтра

[Полный отчёт/Full report](https://github.com/Andrey-Nedov-is-a-human/Computer-Vision-Steerable-Filters/tree/main/materials/Steerable_filter_Report.pdf)

1. Берём функцию двумерного нормального распределения

<img src="/imgs/img2.jpg" width="300"/>

2. Извлекаем компоненты *Gx* и *Gy* градиента функции

3. Получаем направленный фильтр производной по направлению

<img src="/imgs/img3.jpg" width="220"/>

где

<img src="/imgs/img4.jpg" width="260"/>

## Реализация в MathLab

Меняя угол θ мы можем менять направление фильтра.

<img src="/imgs/img1.png" width="700"/>


