# Лабораторная работа №4
-------------------------------------------------
# Игра в кости "Кто больше?"
## Диаграммы взаимодействия UML
## Прецедент "Создать игру"
![create](<./laba4/create2.png>)

### Операция **ValidateGameParams(bots, rounds)**
**Описание**: Проверяет ввёденные пользователем данные на корректность.

**Параметры**: bots - количество ботов; rounds - количество раундов

### Операция **CreateGameSession()**
**Описание**: Создаёт сессию для игры.

**Параметры**: bots - количество ботов; rounds - количество раундов

## Прецедент "Бросить кости"
![brosok](<./laba4/brosok2.png>)

#### Операция **MakeRoll()**
**Описание**: Выполняет 3 итерации броска костей. По окончании возвращает результат броска

**Параметры**: отсутсвуют

#### Операция **SaveRollResult(user, rollResult)**
**Описание**: Сохраняет результат броска для игрока.

**Параметры**: user - игрок, бросивший кости; rollResult - кол-во очков броска

#### Операция **AddScore(player)**
**Описание**: Добавляет игроку 1 очко в общий счёт игры.

**Параметры**: player - игрок, которому необходимо добавить очко

#### Операция **GetNextRoundCount()**
**Описание**: Возвращает количество раундов, которые еще предстоит сыграть

**Параметры**: отсутсвуют

#### Операция **StopGame()**
**Описание**: Завершает игру.

**Параметры**: отсутсвуют


## Прецедент "Покинуть игру"
![leave](<./laba4/leave2.png>)

#### Операция **StopGame()**
**Описание**: Завершает игру.

**Параметры**: отсутсвуют


### Прецедент "Начать раунд"
![start](<./laba4/start2.png>)

#### Операция **StartRound()**
**Описание**: Запускает раунд.

**Параметры**: отсутсвуют



