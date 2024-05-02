# Rumassa

`IQueryable` va `IEnumerable` C# dasturlash tilida ma'lumotlar to'plamlarini olish uchun ishlatiladigan interfeyslar. Farqlarining asosiy sababi, ularning har birining ish faoliyati va qo'llanish xususiyatlari alohida. 

`IEnumerable` faqatgina ma'lumotlar to'plamini olish va u erda ichki qidiruvni bajarish imkoniyatiga ega. Bunday qidiruvlar, ma'lumotlar bazasidan ma'lumotlarni olishda kamchiliklarga olib kelishi mumkin. 

`IQueryable` esa, LINQ (Language Integrated Query) so'rovlarini yaratishda va ma'lumotlar bazasiga yo'naltirishda qo'llaniladi. Bu interfeys asosan `IQueryable<T>` shaklida ishlatiladi va so'rovlarni serverga yuborish uchun dinamik LINQ so'rovlarini yaratishga imkon beradi. Bu, ma'lumotlar bazasiga so'rovni boshqarish uchun samarali va optimallashtirilgan so'rovlarni yaratishga yordam beradi. 

Asosiy farq shundaki, `IEnumerable` ma'lumotlar to'plamini yuklab olish va yaqtinchilikda ishlash uchun ishlatiladi, `IQueryable` esa so'rovlarni yaratish va ma'lumotlar bazasiga yo'naltirish uchun ishlatiladi.