﻿namespace FlyTodayViews
{
    partial class FormFlight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            buttonCancel = new Button();
            label4 = new Label();
            comboBoxSelectDirection = new ComboBox();
            comboBoxSelectPlane = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateTimePickerDeparture = new DateTimePicker();
            textBoxEconomCost = new TextBox();
            textBoxBusinessCost = new TextBox();
            textBoxTimeInFlight = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(312, 283);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(95, 31);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 36);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 1;
            label1.Text = "Направление:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 79);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 3;
            label2.Text = "Дата и время вылета:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(413, 283);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(90, 31);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 120);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 7;
            label4.Text = "Самолет:";
            // 
            // comboBoxSelectDirection
            // 
            comboBoxSelectDirection.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectDirection.FormattingEnabled = true;
            comboBoxSelectDirection.Location = new Point(132, 33);
            comboBoxSelectDirection.Margin = new Padding(3, 4, 3, 4);
            comboBoxSelectDirection.Name = "comboBoxSelectDirection";
            comboBoxSelectDirection.Size = new Size(371, 28);
            comboBoxSelectDirection.TabIndex = 9;
            comboBoxSelectDirection.Format += ComboBoxSelectDirection_Format;
            // 
            // comboBoxSelectPlane
            // 
            comboBoxSelectPlane.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectPlane.FormattingEnabled = true;
            comboBoxSelectPlane.Items.AddRange(new object[] { "Абаза", "Абакан", "Абдулино", "Абинск", "Агидель", "Агрыз", "Адыгейск", "Азнакаево", "Азов", "Ак-Довурак", "Аксай", "Алагир", "Алапаевск", "Алатырь", "Алдан", "Алейск", "Александров", "Александровск", "Александровск-Сахалинский", "Алексеевка", "Алексин", "Алзамай", "Алупка", "Алушта", "Альметьевск", "Амурск", "Анадырь", "Анапа", "Ангарск", "Андреаполь", "Анжеро-Судженск", "Анива", "Апатиты", "Апрелевка", "Апшеронск", "Арамиль", "Аргун", "Ардатов", "Ардон", "Арзамас", "Аркадак", "Армавир", "Армянск", "Арсеньев", "Арск", "Артём", "Артёмовск", "Артёмовский", "Архангельск", "Асбест", "Асино", "Астрахань", "Аткарск", "Ахтубинск", "Ачинск", "Аша", "Бабаево", "Бабушкин", "Бавлы", "Багратионовск", "Байкальск", "Баймак", "Бакал", "Баксан", "Балабаново", "Балаково", "Балахна", "Балашиха", "Балашов", "Балей", "Балтийск", "Барабинск", "Барнаул", "Барыш", "Батайск", "Бахчисарай", "Бежецк", "Белая Калитва", "Белая Холуница", "Белгород", "Белебей", "Белёв", "Белинский", "Белово", "Белогорск", "Белогорск", "Белозерск", "Белокуриха", "Беломорск", "Белоозёрский", "Белорецк", "Белореченск", "Белоусово", "Белоярский", "Белый", "Бердск", "Березники", "Берёзовский", "Берёзовский", "Беслан", "Бийск", "Бикин", "Билибино", "Биробиджан", "Бирск", "Бирюсинск", "Бирюч", "Благовещенск", "Благовещенск", "Благодарный", "Бобров", "Богданович", "Богородицк", "Богородск", "Боготол", "Богучар", "Бодайбо", "Бокситогорск", "Болгар", "Бологое", "Болотное", "Болохово", "Болхов", "Большой Камень", "Бор", "Борзя", "Борисоглебск", "Боровичи", "Боровск", "Бородино", "Братск", "Бронницы", "Брянск", "Бугульма", "Бугуруслан", "Будённовск", "Бузулук", "Буинск", "Буй", "Буйнакск", "Бутурлиновка", "Валдай", "Валуйки", "Велиж", "Великие Луки", "Великий Новгород", "Великий Устюг", "Вельск", "Венёв", "Верещагино", "Верея", "Верхнеуральск", "Верхний Тагил", "Верхний Уфалей", "Верхняя Пышма", "Верхняя Салда", "Верхняя Тура", "Верхотурье", "Верхоянск", "Весьегонск", "Ветлуга", "Видное", "Вилюйск", "Вилючинск", "Вихоревка", "Вичуга", "Владивосток", "Владикавказ", "Владимир", "Волгоград", "Волгодонск", "Волгореченск", "Волжск", "Волжский", "Вологда", "Володарск", "Волоколамск", "Волосово", "Волхов", "Волчанск", "Вольск", "Воркута", "Воронеж", "Ворсма", "Воскресенск", "Воткинск", "Всеволожск", "Вуктыл", "Выборг", "Выкса", "Высоковск", "Высоцк", "Вытегра", "Вышний Волочёк", "Вяземский", "Вязники", "Вязьма", "Вятские Поляны", "Гаврилов Посад", "Гаврилов-Ям", "Гагарин", "Гаджиево", "Гай", "Галич", "Гатчина", "Гвардейск", "Гдов", "Геленджик", "Георгиевск", "Глазов", "Голицыно", "Горбатов", "Горно-Алтайск", "Горнозаводск", "Горняк", "Городец", "Городище", "Городовиковск", "Гороховец", "Горячий Ключ", "Грайворон", "Гремячинск", "Грозный", "Грязи", "Грязовец", "Губаха", "Губкин", "Губкинский", "Гудермес", "Гуково", "Гулькевичи", "Гурьевск", "Гурьевск", "Гусев", "Гусиноозёрск", "Гусь-Хрустальный", "Давлеканово", "Дагестанские Огни", "Далматово", "Дальнегорск", "Дальнереченск", "Данилов", "Данков", "Дегтярск", "Дедовск", "Демидов", "Дербент", "Десногорск", "Джанкой", "Дзержинск", "Дзержинский", "Дивногорск", "Дигора", "Димитровград", "Дмитриев", "Дмитров", "Дмитровск", "Дно", "Добрянка", "Долгопрудный", "Долинск", "Домодедово", "Донецк", "Донской", "Дорогобуж", "Дрезна", "Дубна", "Дубовка", "Дудинка", "Духовщина", "Дюртюли", "Дятьково", "Евпатория", "Егорьевск", "Ейск", "Екатеринбург", "Елабуга", "Елец", "Елизово", "Ельня", "Еманжелинск", "Емва", "Енисейск", "Ермолино", "Ершов", "Ессентуки", "Ефремов", "Железноводск", "Железногорск", "Железногорск", "Железногорск-Илимский", "Жердевка", "Жигулёвск", "Жиздра", "Жирновск", "Жуков", "Жуковка", "Жуковский", "Завитинск", "Заводоуковск", "Заволжск", "Заволжье", "Задонск", "Заинск", "Закаменск", "Заозёрный", "Заозёрск", "Западная Двина", "Заполярный", "Зарайск", "Заречный", "Заречный", "Заринск", "Звенигово", "Звенигород", "Зверево", "Зеленогорск", "Зеленоградск", "Зеленодольск", "Зеленокумск", "Зерноград", "Зея", "Зима", "Златоуст", "Злынка", "Змеиногорск", "Знаменск", "Зубцов", "Зуевка", "Ивангород", "Иваново", "Ивантеевка", "Ивдель", "Игарка", "Ижевск", "Избербаш", "Изобильный", "Иланский", "Инза", "Иннополис", "Инсар", "Инта", "Ипатово", "Ирбит", "Иркутск", "Исилькуль", "Искитим", "Истра", "Ишим", "Ишимбай", "Йошкар-Ола", "Кадников", "Казань", "Калач", "Калач-на-Дону", "Калачинск", "Калининград", "Калининск", "Калтан", "Калуга", "Калязин", "Камбарка", "Каменка", "Каменногорск", "Каменск-Уральский", "Каменск-Шахтинский", "Камень-на-Оби", "Камешково", "Камызяк", "Камышин", "Камышлов", "Канаш", "Кандалакша", "Канск", "Карабаново", "Карабаш", "Карабулак", "Карасук", "Карачаевск", "Карачев", "Каргат", "Каргополь", "Карпинск", "Карталы", "Касимов", "Касли", "Каспийск", "Катав-Ивановск", "Катайск", "Качканар", "Кашин", "Кашира", "Кедровый", "Кемерово", "Кемь", "Керчь", "Кизел", "Кизилюрт", "Кизляр", "Кимовск", "Кимры", "Кингисепп", "Кинель", "Кинешма", "Киреевск", "Киренск", "Киржач", "Кириллов", "Кириши", "Киров", "Киров", "Кировград", "Кирово-Чепецк", "Кировск", "Кировск", "Кирс", "Кирсанов", "Киселёвск", "Кисловодск", "Клин", "Клинцы", "Княгинино", "Ковдор", "Ковров", "Ковылкино", "Когалым", "Кодинск", "Козельск", "Козловка", "Козьмодемьянск", "Кола", "Кологрив", "Коломна", "Колпашево", "Кольчугино", "Коммунар", "Комсомольск", "Комсомольск-на-Амуре", "Конаково", "Кондопога", "Кондрово", "Константиновск", "Копейск", "Кораблино", "Кореновск", "Коркино", "Королёв", "Короча", "Корсаков", "Коряжма", "Костерёво", "Костомукша", "Кострома", "Котельники", "Котельниково", "Котельнич", "Котлас", "Котово", "Котовск", "Кохма", "Красавино", "Красноармейск", "Красноармейск", "Красновишерск", "Красногорск", "Краснодар", "Краснозаводск", "Краснознаменск", "Краснознаменск", "Краснокаменск", "Краснокамск", "Красноперекопск", "Краснослободск", "Краснослободск", "Краснотурьинск", "Красноуральск", "Красноуфимск", "Красноярск", "Красный Кут", "Красный Сулин", "Красный Холм", "Кремёнки", "Кропоткин", "Крымск", "Кстово", "Кубинка", "Кувандык", "Кувшиново", "Кудрово", "Кудымкар", "Кузнецк", "Куйбышев", "Кукмор", "Кулебаки", "Кумертау", "Кунгур", "Купино", "Курган", "Курганинск", "Курильск", "Курлово", "Куровское", "Курск", "Куртамыш", "Курчалой", "Курчатов", "Куса", "Кушва", "Кызыл", "Кыштым", "Кяхта", "Лабинск", "Лабытнанги", "Лагань", "Ладушкин", "Лаишево", "Лакинск", "Лангепас", "Лахденпохья", "Лебедянь", "Лениногорск", "Ленинск", "Ленинск-Кузнецкий", "Ленск", "Лермонтов", "Лесной", "Лесозаводск", "Лесосибирск", "Ливны", "Ликино-Дулёво", "Липецк", "Липки", "Лиски", "Лихославль", "Лобня", "Лодейное Поле", "Лосино-Петровский", "Луга", "Луза", "Лукоянов", "Луховицы", "Лысково", "Лысьва", "Лыткарино", "Льгов", "Любань", "Люберцы", "Любим", "Людиново", "Лянтор", "Магадан", "Магас", "Магнитогорск", "Майкоп", "Майский", "Макаров", "Макарьев", "Макушино", "Малая Вишера", "Малгобек", "Малмыж", "Малоархангельск", "Малоярославец", "Мамадыш", "Мамоново", "Мантурово", "Мариинск", "Мариинский Посад", "Маркс", "Махачкала", "Мглин", "Мегион", "Медвежьегорск", "Медногорск", "Медынь", "Межгорье", "Междуреченск", "Мезень", "Меленки", "Мелеуз", "Менделеевск", "Мензелинск", "Мещовск", "Миасс", "Микунь", "Миллерово", "Минеральные Воды", "Минусинск", "Миньяр", "Мирный", "Мирный", "Михайлов", "Михайловка", "Михайловск", "Михайловск", "Мичуринск", "Могоча", "Можайск", "Можга", "Моздок", "Мончегорск", "Морозовск", "Моршанск", "Мосальск", "Москва", "Муравленко", "Мураши", "Мурино", "Мурманск", "Муром", "Мценск", "Мыски", "Мытищи", "Мышкин", "Набережные Челны", "Навашино", "Наволоки", "Надым", "Назарово", "Назрань", "Называевск", "Нальчик", "Нариманов", "Наро-Фоминск", "Нарткала", "Нарьян-Мар", "Находка", "Невель", "Невельск", "Невинномысск", "Невьянск", "Нелидово", "Неман", "Нерехта", "Нерчинск", "Нерюнгри", "Нестеров", "Нефтегорск", "Нефтекамск", "Нефтекумск", "Нефтеюганск", "Нея", "Нижневартовск", "Нижнекамск", "Нижнеудинск", "Нижние Серги", "Нижний Ломов", "Нижний Новгород", "Нижний Тагил", "Нижняя Салда", "Нижняя Тура", "Николаевск", "Николаевск-на-Амуре", "Никольск", "Никольск", "Никольское", "Новая Ладога", "Новая Ляля", "Новоалександровск", "Новоалтайск", "Новоаннинский", "Нововоронеж", "Новодвинск", "Новозыбков", "Новокубанск", "Новокузнецк", "Новокуйбышевск", "Новомичуринск", "Новомосковск", "Новопавловск", "Новоржев", "Новороссийск", "Новосибирск", "Новосиль", "Новосокольники", "Новотроицк", "Новоузенск", "Новоульяновск", "Новоуральск", "Новохопёрск", "Новочебоксарск", "Новочеркасск", "Новошахтинск", "Новый Оскол", "Новый Уренгой", "Ногинск", "Нолинск", "Норильск", "Ноябрьск", "Нурлат", "Нытва", "Нюрба", "Нягань", "Нязепетровск", "Няндома", "Облучье", "Обнинск", "Обоянь", "Обь", "Одинцово", "Озёрск", "Озёрск", "Озёры", "Октябрьск", "Октябрьский", "Окуловка", "Олёкминск", "Оленегорск", "Олонец", "Омск", "Омутнинск", "Онега", "Опочка", "Орёл", "Оренбург", "Орехово-Зуево", "Орлов", "Орск", "Оса", "Осинники", "Осташков", "Остров", "Островной", "Острогожск", "Отрадное", "Отрадный", "Оха", "Оханск", "Очёр", "Павлово", "Павловск", "Павловский Посад", "Палласовка", "Партизанск", "Певек", "Пенза", "Первомайск", "Первоуральск", "Перевоз", "Пересвет", "Переславль-Залесский", "Пермь", "Пестово", "Петров Вал", "Петровск", "Петровск-Забайкальский", "Петрозаводск", "Петропавловск-Камчатский", "Петухово", "Петушки", "Печора", "Печоры", "Пикалёво", "Пионерский", "Питкяранта", "Плавск", "Пласт", "Плёс", "Поворино", "Подольск", "Подпорожье", "Покачи", "Покров", "Покровск", "Полевской", "Полесск", "Полысаево", "Полярные Зори", "Полярный", "Поронайск", "Порхов", "Похвистнево", "Почеп", "Починок", "Пошехонье", "Правдинск", "Приволжск", "Приморск", "Приморск", "Приморско-Ахтарск", "Приозерск", "Прокопьевск", "Пролетарск", "Протвино", "Прохладный", "Псков", "Пугачёв", "Пудож", "Пустошка", "Пучеж", "Пушкино", "Пущино", "Пыталово", "Пыть-Ях", "Пятигорск", "Радужный", "Радужный", "Райчихинск", "Раменское", "Рассказово", "Ревда", "Реж", "Реутов", "Ржев", "Родники", "Рославль", "Россошь", "Ростов", "Ростов-на-Дону", "Рошаль", "Ртищево", "Рубцовск", "Рудня", "Руза", "Рузаевка", "Рыбинск", "Рыбное", "Рыльск", "Ряжск", "Рязань", "Саки", "Салават", "Салаир", "Салехард", "Сальск", "Самара", "Санкт-Петербург", "Саранск", "Сарапул", "Саратов", "Саров", "Сасово", "Сатка", "Сафоново", "Саяногорск", "Саянск", "Светлогорск", "Светлоград", "Светлый", "Светогорск", "Свирск", "Свободный", "Себеж", "Севастополь", "Северо-Курильск", "Северобайкальск", "Северодвинск", "Североморск", "Североуральск", "Северск", "Севск", "Сегежа", "Сельцо", "Семёнов", "Семикаракорск", "Семилуки", "Сенгилей", "Серафимович", "Сергач", "Сергиев Посад", "Сердобск", "Серов", "Серпухов", "Сертолово", "Сибай", "Сим", "Симферополь", "Сковородино", "Скопин", "Славгород", "Славск", "Славянск-на-Кубани", "Сланцы", "Слободской", "Слюдянка", "Смоленск", "Снежинск", "Снежногорск", "Собинка", "Советск", "Советск", "Советск", "Советская Гавань", "Советский", "Сокол", "Солигалич", "Соликамск", "Солнечногорск", "Соль-Илецк", "Сольвычегодск", "Сольцы", "Сорочинск", "Сорск", "Сортавала", "Сосенский", "Сосновка", "Сосновоборск", "Сосновый Бор", "Сосногорск", "Сочи", "Спас-Деменск", "Спас-Клепики", "Спасск", "Спасск-Дальний", "Спасск-Рязанский", "Среднеколымск", "Среднеуральск", "Сретенск", "Ставрополь", "Старая Купавна", "Старая Русса", "Старица", "Стародуб", "Старый Крым", "Старый Оскол", "Стерлитамак", "Стрежевой", "Строитель", "Струнино", "Ступино", "Суворов", "Судак", "Суджа", "Судогда", "Суздаль", "Сунжа", "Суоярви", "Сураж", "Сургут", "Суровикино", "Сурск", "Сусуман", "Сухиничи", "Сухой Лог", "Сызрань", "Сыктывкар", "Сысерть", "Сычёвка", "Сясьстрой", "Тавда", "Таганрог", "Тайга", "Тайшет", "Талдом", "Талица", "Тамбов", "Тара", "Тарко-Сале", "Таруса", "Татарск", "Таштагол", "Тверь", "Теберда", "Тейково", "Темников", "Темрюк", "Терек", "Тетюши", "Тимашёвск", "Тихвин", "Тихорецк", "Тобольск", "Тогучин", "Тольятти", "Томари", "Томмот", "Томск", "Топки", "Торжок", "Торопец", "Тосно", "Тотьма", "Трёхгорный", "Троицк", "Трубчевск", "Туапсе", "Туймазы", "Тула", "Тулун", "Туран", "Туринск", "Тутаев", "Тында", "Тырныауз", "Тюкалинск", "Тюмень", "Уварово", "Углегорск", "Углич", "Удачный", "Удомля", "Ужур", "Узловая", "Улан-Удэ", "Ульяновск", "Унеча", "Урай", "Урень", "Уржум", "Урус-Мартан", "Урюпинск", "Усинск", "Усмань", "Усолье", "Усолье-Сибирское", "Уссурийск", "Усть-Джегута", "Усть-Илимск", "Усть-Катав", "Усть-Кут", "Усть-Лабинск", "Устюжна", "Уфа", "Ухта", "Учалы", "Уяр", "Фатеж", "Феодосия", "Фокино", "Фокино", "Фролово", "Фрязино", "Фурманов", "Хабаровск", "Хадыженск", "Ханты-Мансийск", "Харабали", "Харовск", "Хасавюрт", "Хвалынск", "Хилок", "Химки", "Холм", "Холмск", "Хотьково", "Цивильск", "Цимлянск", "Циолковский", "Чадан", "Чайковский", "Чапаевск", "Чаплыгин", "Чебаркуль", "Чебоксары", "Чегем", "Чекалин", "Челябинск", "Чердынь", "Черемхово", "Черепаново", "Череповец", "Черкесск", "Чёрмоз", "Черноголовка", "Черногорск", "Чернушка", "Черняховск", "Чехов", "Чистополь", "Чита", "Чкаловск", "Чудово", "Чулым", "Чусовой", "Чухлома", "Шагонар", "Шадринск", "Шали", "Шарыпово", "Шарья", "Шатура", "Шахты", "Шахунья", "Шацк", "Шебекино", "Шелехов", "Шенкурск", "Шилка", "Шимановск", "Шиханы", "Шлиссельбург", "Шумерля", "Шумиха", "Шуя", "Щёкино", "Щёлкино", "Щёлково", "Щигры", "Щучье", "Электрогорск", "Электросталь", "Электроугли", "Элиста", "Энгельс", "Эртиль", "Югорск", "Южа", "Южно-Сахалинск", "Южно-Сухокумск", "Южноуральск", "Юрга", "Юрьев-Польский", "Юрьевец", "Юрюзань", "Юхнов", "Ядрин", "Якутск", "Ялта", "Ялуторовск", "Янаул", "Яранск", "Яровое", "Ярославль", "Ярцево", "Ясногорск", "Ясный", "Яхрома" });
            comboBoxSelectPlane.Location = new Point(168, 117);
            comboBoxSelectPlane.Margin = new Padding(3, 4, 3, 4);
            comboBoxSelectPlane.Name = "comboBoxSelectPlane";
            comboBoxSelectPlane.Size = new Size(335, 28);
            comboBoxSelectPlane.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 157);
            label5.Name = "label5";
            label5.Size = new Size(299, 20);
            label5.TabIndex = 11;
            label5.Text = "Стоимость одного билета эконом-класса:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 196);
            label6.Name = "label6";
            label6.Size = new Size(296, 20);
            label6.TabIndex = 12;
            label6.Text = "Стоимость одного билета бизнес-класса:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 235);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 13;
            label7.Text = "Время в пути:";
            // 
            // dateTimePickerDeparture
            // 
            dateTimePickerDeparture.Location = new Point(168, 74);
            dateTimePickerDeparture.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            dateTimePickerDeparture.Size = new Size(335, 27);
            dateTimePickerDeparture.TabIndex = 14;
            // 
            // textBoxEconomCost
            // 
            textBoxEconomCost.Location = new Point(321, 154);
            textBoxEconomCost.Margin = new Padding(3, 4, 3, 4);
            textBoxEconomCost.Name = "textBoxEconomCost";
            textBoxEconomCost.Size = new Size(182, 27);
            textBoxEconomCost.TabIndex = 15;
            // 
            // textBoxBusinessCost
            // 
            textBoxBusinessCost.Location = new Point(321, 193);
            textBoxBusinessCost.Margin = new Padding(3, 4, 3, 4);
            textBoxBusinessCost.Name = "textBoxBusinessCost";
            textBoxBusinessCost.Size = new Size(182, 27);
            textBoxBusinessCost.TabIndex = 16;
            // 
            // textBoxTimeInFlight
            // 
            textBoxTimeInFlight.Location = new Point(262, 232);
            textBoxTimeInFlight.Margin = new Padding(3, 4, 3, 4);
            textBoxTimeInFlight.Name = "textBoxTimeInFlight";
            textBoxTimeInFlight.Size = new Size(186, 27);
            textBoxTimeInFlight.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(454, 235);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 18;
            label8.Text = "часов";
            // 
            // FormFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 321);
            Controls.Add(label8);
            Controls.Add(textBoxTimeInFlight);
            Controls.Add(textBoxBusinessCost);
            Controls.Add(textBoxEconomCost);
            Controls.Add(dateTimePickerDeparture);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBoxSelectPlane);
            Controls.Add(comboBoxSelectDirection);
            Controls.Add(label4);
            Controls.Add(buttonCancel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormFlight";
            Text = "Рейс";
            Load += FormFlight_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private Label label2;
        private Button buttonCancel;
        private Label label4;
        private ComboBox comboBoxSelectDirection;
        private ComboBox comboBoxSelectPlane;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePickerDeparture;
        private TextBox textBoxEconomCost;
        private TextBox textBoxBusinessCost;
        private TextBox textBoxTimeInFlight;
        private Label label8;
    }
}