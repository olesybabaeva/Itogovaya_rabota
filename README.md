# Итоговая контрольная работа по основному блоку. #

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

# Задача: #

>> Написать программу, которая из имющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекоендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


# Решение: #

1. Запрашиваем размер массива у пользователя с помощью `Console.Write()`.
2. С помощью `Console.ReadLine()` считываем введенный размер.
3. Создаем массив требуемого размера (`number`) с помощью функции`string[] CreateArray()`.
4. Затем с помощью функции `int CheckArray()` считаем количество элементов в массиве, которые содержат не более 3 символов.
5. С помощью функции `string[] NewArray()` создаем новый массив, который берет только те элементы, которые содержат не более 3 символов.


# Алгоритм: #

![алгоритм](Диаграмма.png)
