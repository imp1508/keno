# Лабораторная работа №3
Диаграмма последовательности

## Прецедент «Начать игру»
![Logo](https://github.com/imp1508/keno/blob/main/diagrams/start_game.png?raw=true)

| Операция       | Возврат формы начала игры              |
|----------------|----------------------------------------|
| Ссылки         | Прецедент: Начать игру                 |
| Предусловие    | Приложение запущено                    |
| Постусловие    | Система возвращает форму начала игры   |

#### Основной вариант
| Операция       | Возврат формы игры                                         |
|----------------|------------------------------------------------------------|
| Ссылки         | Прецедент: Начать игру                                     |
| Предусловие    | Нажата кнопка "Начать игру" и игрок выбрал баланс          |
| Постусловие    | Система возвращает форму игры с выбраным балансом          |

#### Альтернативный вариант
| Операция       | Возврат формы игры                                   |
|----------------|------------------------------------------------------|
| Ссылки         | Прецедент: Начать игру                               |
| Предусловие    | Нажата кнопка "Начать игру" и игрок не выбрал баланс |
| Постусловие    | Система возвращает форму игры с стандартным балансом |

## Прецедент «Играть»
![Logo](https://github.com/imp1508/keno/blob/main/diagrams/play.png?raw=true)

| Операция       | Выбор количества билетов                               |
|----------------|--------------------------------------------------------|
| Ссылки         | Прецедент: Играть                                      |
| Предусловие    | Выбрана ставка                                         |
| Постусловие    | Рассчитывается сумма ставки                            |

#### Основной вариант
| Операция       | Нажатие кнопки "Играть"                                          |
|----------------|------------------------------------------------------------------|
| Ссылки         | Прецедент: Играть                                                |
| Предусловие    | Выбрана ставка и количество билетов, достаточно денег на балансе |
| Постусловие    | Определяются итоги розыгрыша                                     |

#### Альтернативный вариант
| Операция       | Нажатие кнопки "Играть"                                            |
|----------------|--------------------------------------------------------------------|
| Ссылки         | Прецедент: Играть                                                  |
| Предусловие    | Выбрана ставка и количество билетов, недостаточно денег на балансе |
| Постусловие    | Возвращается уведомление о недостаточном балансе                   |

## Прецедент «Изменить ставку»
![Logo](https://github.com/imp1508/keno/blob/main/diagrams/change_bet.png?raw=true)

| Операция       | Ввод суммы ставки           |
|----------------|-----------------------------|
| Ссылки         | Прецедент: Изменить ставку  |
| Предусловие    | Создана игра                |
| Постусловие    | Сохраняется значение ставки |

#### Основной вариант
| Операция       | Нажатие кнопки "Изменить ставку"                            |
|----------------|-------------------------------------------------------------|
| Ссылки         | Прецедент: Изменить ставку                                  |
| Предусловие    | Введена сумма ставки и на балансе достаточно денег          |
| Постусловие    | Изменяется ставка                                           |

#### Альтернативный вариант
| Операция       | Нажатие кнопки "Изменить ставку"                     |
|----------------|------------------------------------------------------|
| Ссылки         | Прецедент: Изменить ставку                           |
| Предусловие    | Введена сумма ставки и на балансе недостаточно денег |
| Постусловие    | Возвращается уведомление о недостаточном баланса     |

## Прецедент «Выбрать ячейки»
![Logo](https://github.com/imp1508/keno/blob/main/diagrams/choose_cells.png?raw=true)

| Операция       | Ввод суммы ставки           |
|----------------|-----------------------------|
| Ссылки         | Прецедент: Выбрать ячейки   |
| Предусловие    | Создана игра                |
| Постусловие    | Ячейки выбраны              |

#### Основной вариант
| Операция       | Выбор ячеек вчучную                                         |
|----------------|-------------------------------------------------------------|
| Ссылки         | Прецедент: Выбрать ячейки                                   |
| Предусловие    | Игрок хочет выбрать ячейки сам                              |
| Постусловие    | Регистрируются выбранные ячейки                             |

#### Альтернативный вариант
| Операция       | Нажатие кнопки "Выбрать случайно"                    |
|----------------|------------------------------------------------------|
| Ссылки         | Прецедент: Выбрать ячейки                            |
| Предусловие    | Игрок не хочет выбирать ячейки сам                   |
| Постусловие    | Регистрируются случайно выбранные ячейки             |

## Прецедент «Выйти из игры»
![Logo](https://github.com/imp1508/keno/blob/main/diagrams/close_game.png?raw=true)

| Операция       | Ввод суммы ставки           |
|----------------|-----------------------------|
| Ссылки         | Прецедент: Выйти из игры    |
| Предусловие    | Игрок в форме начала игры   |
| Постусловие    | Игра закрывается            |