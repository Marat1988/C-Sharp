<b>Windows Form Application</b>
#
<b>HomeWork 1-2</b>

Задание 1

Добавьте к предыдущей программе (автозаправка) всплывающие подсказки, а также строку состояния.<br>
В строке состояния добавьте элемент <b>StatusLabel</b>. На срабатывание таймера определите переключение StatusLabel в строке состояния для попеременного отображения времени и даты.<br>
В строке состояния в <b>DropDownButton</b> разместите текущий день недели.

![12](https://user-images.githubusercontent.com/108996479/194755730-2f337eee-9999-4853-ba38-481cef2c04c3.jpg)

Создайте дополнительное меню с настройками, в котором предусмотрите возможность изменения цвета формы программы с использованием элементов TrackBar, как в примере выше. Используйте Panel для «выезжающего» окна. К строке состояния добавьте <b>DropDownButton</b> для выбора языка интерфейса (2 языка минимум). Для изменения языка воспользуй тесь следующим кодом:
![12](https://user-images.githubusercontent.com/108996479/194755754-600aaf78-8908-4e07-a777-e359d93877e3.jpg)

Предусмотрите возможность сворачивания окна приложения в системный трей и разворачивание из него.

Задание 2

Разработайте программу, которая позволяет пользователю осуществлять поиск файлов по заданному критерию. Приложение состоит из двух форм – главное окно и окно поиска. Пользователь может открыть сколько угодно окон для поиска. Окно поиска запускается немодально. В окне поиска пользователь выбирает папку, в которой будет идти поиск и вводит маску поиска, например «*.doc». Найденные файлы отображаются в списке.

Задание 3

Фирма продает составляющие компьютера. Первая форма отвечает за учет продаж, вторая за добавление и редактирование составляющих.

Первая форма:<br>
Список, выпадающий список, текстовое поле, кнопка вызовавторой формы. В выпадающем списке появляются наименования всех товаров, которые в наличие в магазине. Пользователь выбирает товар, в текстовом окне, которое нельзя редактировать, появляется цена. Пользователь нажимает «добавить» и товар добавляется в список продаж. Также должно быть окошко, которое выводит общую стоимость.<br>

Вторая форма:<br>
Информация о комплектующих (наименование, характеристика, описание и цена) вводится в текстовые поля; в список добавляется текстовая строка, содержащая информацию о товаре, кроме цены, цена в списке не видна, но содержится; также комплектующие можно редактировать.

Задание 4

Разработайте приложение, которое состоит из двух форм. Первая форма содержит TextBox доступный только для чтения и две кнопки «загрузить файл» и «редактировать». Кнопка «редактировать» изначально неактивна. При нажатии на первую кнопку, открывается диалог и пользователю предлагают выбрать текстовый файл. Выбранный файл загружается в TextBox и кнопка «редактировать» становится активной. При нажатии на вторую кнопку открывается вторая форма (не модально), которая содержит TextBox доступный для редактирования и две кнопки «Сохранить» и «Отменить». При нажатии на первую кнопку изменения отображаются в TextBox первой формы.

Задание 5

Разработать текстовый редактор, организовать открытие/сохранение текстовых файлов.
<ul>
  <li>В панели инструментов расположить кнопки (Открыть, сохранить, новый документ, копировать, вырезать, вставить, отменить, кнопка настройки редактора(цвет шрифта, цвет фона, шрифт));</li>
  <li>Меню должно дублировать панель инструментов (+ выделить все, + сохранить как);</li>
  <li>В Заголовке окна находится полный путь к файлу;</li>
  <li>Организовать контекстное меню для окна редактора (Копировать, Вырезать, Вставить, Отменить).</li>
</ul>

Задание 6

Написать программу «Проводник»
<ul>
  <li>При первом запуске программа отображает список доступных дисков;</li>
  <li>Программа должна содержать дерево дисков, строку адреса, меню, панель инструментов и окно для отображения содержимого папки;</li>
  <li>Дерево дисков отображает только диски и папки (можно реализовать с помощью ListBox);</li>
  <li>При двойном щелчке по папке – окно содержимого отображаются файлы и подпапки;</li>
  <li>Программа должна иметь развернутое меню, контекстное меню и возможность работы с горячими клавишами.</li>
</ul>

Задание 7

Создайте Windows Forms приложение
<ul>
  <li>Добавьте на него текстовое поле с именем TopLevelMenu;</li>
  <li>Добавьте текстовое поле с именем SubItem;</li>
  <li>Добавьте кнопку «Добавить пункт меню»;</li>
  <li>Добавьте кнопку «Добавить подменю»;</li>
  <li>При нажатии на кнопку «Добавить пункт меню» должен добавляться пункт меню верхнего уровня, с именем указанным в поле TopLevelMenu;</li>
  <li>При нажатии на кнопку «Добавить подменю» в текущее меню должен добавляться подпункт меню с именем указанным в поле SubItem.</li>  
</ul>

#
<b>HomeWork 3-4</b>

Задание 1

Создайте приложение на базе <b>TreeView</b> для просмотра каталогов файлов с вложенными каталогами.

Задание 2

Создайте приложение на базе <b>ListView</b> для просмотра каталога файлов в 5-ти вариантах, для вариантов иконки-плитка-список изображений отображать содержимое графических файлов.

Задание 3

Создайте редактор на базе <b>RichTextBox</b> и добавьте в него возможность выбора из каталога и просмотра содержимого файла перетаскиванием файла на поле редактора.

Задание 4

Создать приложение отображающее информацию о файлах и директориях с использованием элементов управления <b>ListView</b> и <b>TreeView</b>: отображение файлов и папок всех логических дисков с помощью <b>TreeView</b>, при выборе файла или папки в <b>ListView</b> отображаются все свойства (дата создания, размер, тип, количество файлов для папки, атрибуты и т.д.)

Задание 5

Создать MDI-приложение с использованием стандартных диалоговых окон SaveFileDialog, OpenFileDialog, позволяющее:
<ul>
  <li>Сохранять вводимые данные в текстовом файле;/li>
  <li>Просматривать, корректировать, удалять записи из файла;/li>
  <li>Выводить результаты работы программы на экран и сохранять в другой текстовый файл;/li>
  <li>Иметь возможность делать выборку данных по различным критериям;/li>
  <li>Переносить данные из одной формы в другую./li>
</ul>
Добавить пункты меню для сохранения объектов в файл и загрузки. При сохранении использовать стандартные диалоговые окна и механизм сериализации. В класс добавить поле дата создания объекта. Это поле не сериализовать, а при десериализации заново устанавливать по системной дате.<br>
<br>
<b>Вариант 14</b>
<br>
<br>
Имеется список сотрудников фирмы, в котором записаны:</br>
<ul>
  <li>Фамилия;</li>
  <li>Имя;</li>
  <li>Отчество;</li>
  <li>Дата рождения (дд/мм/гггг);</li>
  <li>Место рождения.</li>
</ul>
Определить фамилии, возраст, а также количество сотрудников, которые родились в определенном городе (вводится с клавиатуры).

#
<b>HomeWork 5-6</b>

Задание 1

Создайте приложение, которое будет рисовать шахматную доску и шахматные фигуры на клиентской области формы. Для каждой фигуры должно отображаться контекстное меню.

Задание 2

Создайте приложение, с помощью которого можно рисовать различные геометрические формы на клиентской области. Приложение должно иметь в вверху панель инструментов с кнопками, которые позволяли заходить в настройки геометрического примитива и рисовать их. Нарисованные примитивы должны отображаться на клиентской области формы. Так же добавьте возможность сохранения композиции на жесткий диск в любом формате.

Задание 3

Разработать построитель математических графиков функций.

Задание 4

Разработать приложение, создающее диаграммы.

#
<b>HomeWork 7-8</b>

Задание 1

Вывести на экран свое (краткое!!!) резюме с помощью последовательности MessageBox’ов (числом не менее трех). Причем на заголовке последнего должно отобразиться среднее число символов на странице (общее количество символов в резюме / количество MessageBox’ов).

Задание 2

Написать функцию, которая «угадывает» задуманное пользователем число от 1 до 2000. Для запроса к пользователю использовать MessageBox. После того, как число отгадано, необходимо вывести количество запросов, потребовавшихся для этого, и предоставить пользователю возможность сыграть еще раз, не выходя из программы (MessageBox’ы оформляются кнопками и значками соответственно ситуации).

Задание 3

Представьте, что у вас на форме есть прямоугольник, границы которого на 10 пикселей отстоят от границ рабочей области формы. Необходимо создать следующие обработчики:
<ul>
  <li>Обработчик нажатия левой кнопки мыши, который выводит сообщение о том, где находится текущая точка: внутри прямоугольника, снаружи, на границе прямоугольника. Если при нажатии левой кнопки мыши была нажата кнопка <b>Control (Ctrl)</b>, то приложение должно закрываться;</li>
  <li>Обработчик нажатия правой кнопки мыши, который выводит в заголовок окна информацию о размере клиентской (рабочей) области окна в виде: Ширина = x, Высота = y, где x и y – соответствующие параметры вышего окна;</li> 
  <li>Обработчик перемещения указателя мыши в пределах рабочей области, который должен выводить в заголовок окна текущие координаты мыши x и y.</li> 
</ul>

Задание 4

Разработать приложение, созданное на основе форме. <br>
<ul>
  <li>Пользователь «щелкает» левой кнопкой мыши по форме и, не отпуская кнопку, ведет по ней мышку, а в момент отпускания кнопки по полученным координатам прямоугольника (вам, конечно, известно, что двух точек на плоскости достаточно для создания прямоугольника) необходимо создать «статик», который содержит свой порядковый номер (имеется в виду порядок появления на форме).</li>
  <li>Минимальный размер «статика» составляет 10х10, при попытке создания элемента меньших размеров пользователь должен увидеть соответствующее предупреждение.</li>
  <li>При щелчке правой кнопкой мыши над поверхностью «статика» в заголовке окна должна появиться информация о его площади и координатах (относительно формы). В случае, если в точке щелчка находится несколько «статиков», то предпочтение отдается «статику» с наибольшим порядковым номером.</li>
  <li>При двойном щелчке левой кнопки мыши над поверхностью «статика» он должен исчезнуть с формы. В случае, если в точке щелчка находится несколько «статиков», то предпочтение отдается «статику» с наименьшим порядковым номером.</li>
</ul>

Задание 5

Разработать приложение «убегающий статик»:) Суть приложения: на форме расположен статический элемент управления («статик»). Пользователь пытается подвести курсор мыши к «статику», и, если курсор находиться близко со статиком, элемент управления «убегает». Предусмотреть перемещение «статика» только в пределах формы.

Задание 6

Написать программу, которая по введенной дате определяет день недели. Результат выводить в текстовое поле (желательно по-русски).

Задание 7

Написать программу, вычисляющую сколько осталось времени до указанной даты (дата вводится с клавиатуры в <b>Edit</b>). Предусмотреть возможность выдачи результата в годах, месяцах, днях, минутах, секундах (для первых двух вариантов ответ дробный). Для переключения между вариантами желательно использовать переключатели (<b>RadioButton</b>).

Задание 8

Постановка задачи:
Владелец автозаправки «BestOil» заказал следующую программу. Когда автозаправка только начинает свою деятельность, владелец обычно хочет получать максимальноb большой доход, который планирует увеличить за счет дополнительных услуг. Поэтому на автозаправке будет действовать небольшое кафе. Но, в то же время он может нанять только одного работника на должность кассира, а потому назначение программы – учет продаж бензина и ассортимента товаров в миникафе.
![Без имени](https://user-images.githubusercontent.com/108996479/199026018-6db5e273-34b6-4ef6-bd45-085693492dec.jpg)

<b>Требования к поставленной задаче:</b></br>
Для удобства окно разделено на три части: первая для осуществления вычислений, касающихся непосредственно заправки автомобилей топливом; вторая – покупки в мини-кафе; третья часть для вычисления суммы оплаты.</br>
<b>Итак, первая группа элементов Автозаправка.</b></br>
<b>ComboBox</b> – выпадающий список с перечнем имеющегося горючего. По умолчанию, сразу при запуске программы должен быть выбран определенный вид горючего и в TextBox (или например Label) должна отображаться цена на данный вид продукта. При каждой смене выбора бензина, цена в данном поле будет соответственно меняться.</br>
Далее, дается возможность выбора: купить горючее, указав необходимое количество литров или указав, на какую сумму клиент будет заправляться. При этом, после выбора одного из двух вариантов предоставления услуги, ненужное поле становится заблокированным. В случае ввода суммы денег, группа «К оплате» изменит название на «К выдаче»; вместо суммы следует выводить количество литров, соответственно изменяются единицы измерения с «грн..» на «л»..</br>
<b>Вторая группа Мини-кафе.</b></br>
Для удобства, все возможные товары выведены сразу в данной части. Для каждого продукта предусмотрены CheckBox с названием товара, рядом выводится цена (неактивный TextBox). При получении заказа для возможности ввода количества заказанных единиц товара, следует поставить «галочку» в CheckBox напротив соответствующего товара.</br>
<b>Последняя – «К оплате».</b></br>
Содержит кнопку, которая отвечает за осуществление вычисления и вывода сумм в соответствующих полях.</br>
После того, как выведена сумма, через (например) 10 секунд должен появиться запрос на очистку формы, то есть при появлении следующего клиент: да – все поля принимают значения по умолчанию, нет – неизменное состояние остается еще на 10 секунд. При выходе из программы (закончился рабочий день) должно появиться окно с сообщением, какова общая сумма выручки за данный день. Или эту сумму можно сразу выводить в самой форме и изменять после каждого осуществления расчета с клиентом.</br>
Кроме этого, придайте форме эстетический вид (цвета, шрифты, рисунки ...). При обоснованной необходимости и интересном решении функциональности программы разрешается вносить изменения во внешний вид формы или набор элементов.

Задание 9

Создайте приложение размером до 720х480 пикселов и разместите на главной форме необходимые элементы управления для получения информации:
<ul>
 <li>Фамилия</li>
 <li>Имя</li>
 <li>Отчество</li>
 <li>Пол</li>
 <li>Год и дата рождения</li>
 <li>Семейный статус</li>
 <li>Дополнительная информация</li>
</ul>
Добавьте кнопку Save и обработчик нажатия кнопки для сохранения информации из элементов управления в файл.</br>
</br>

Задание 10

Подсчитайте количество дней между выбранными датами с помощью <b>DateTimePicker</b> и выведите результат на форму с использование элемента <b>Label</b>. Форму главного окна сделайте в виде круга.

Задание 11

Пользователь вводит дату своего рождения в элементы <b>TextBox</b>. Программа выделяет в элементе MonthCalendar и отображает указанный день.

Задание 12

Написать приложение, которое отображает количество текста, прочитанного из файла с помощью <b>ProgressBar.</b>

Задание 13

Написать приложение – анкету, которую предлагается заполнить пользователю: имя, фамилия, e-mail, телефон. После нажатия на кнопку «Добавить» Информация о пользователе попадает в <b>ListBox</b>, в котором храниться информация о всех пользователях. Также, в ListBox, по клику на строку с информацией о пользователе следует предусмотреть возможность удаления пользователя из коллекции элементов ListBox, а также редактирования. Редактирование информации о пользователе производиться путем подстановки данных из ListBox, в соответствующие поля для ввода новой информации.</br>

Предусмотреть:</br>
<ul>
  <li>экспорт/импорт всей информации о пользователях в текстовый файл;</li>
  <li>экспорт/импорт всей информации о пользователях в *.xml файл.</li>
</ul>
