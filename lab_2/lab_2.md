# Лабораторная работа №2
Диаграмма классов
![Logo](https://github.com/imp1508/keno/blob/main/diagrams/erd.png?raw=true)
## Игра
> Игрок создает игру

> Номер инкрементируется

> Баланс выбирается пользователем

## Розыгрыш
> Номер розыгрыша инкрементируется
 
> Ставка определяется игроком

> Набор ячеек выбирается игроком

## Билет
> Номер билета инкрементируется

## Игра – Розыгрыш
> Одна Игра может иметь несколько Розыгрышей

> Розыгрыш принадлежит только одной Игре

> Сумма всех билетов розыгрыша прибавляется к балансу Игры

## Розыгрыш – Билет
> Один розыгрыш может иметь несколько Билетов

> Билет принадлежит только одному розыгрышу

> Победная комбинация ячеек определяется системой

> Выигрыш Билета рассчитывается в зависимости от соответствия ячеек Розыгрыша ячейкам Билета
