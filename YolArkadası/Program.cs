        bool continuePlanning = true;

        while (continuePlanning)
        {
            // Tatil için gitmek istediğiniz yerin bilgilendirmesi
                 Console.WriteLine("Nerede tatil yapmak istersiniz?\n(Bodrum 40000 TL, Marmaris 30000 TL, Çeşme 50000 TL\nNot: Fiyatlar tek kişiliktir.)");
                 string location;
            do
            {
                    location = Console.ReadLine().ToLower(); // Gitmek istediğin yerin seçim ekranı

                if (location != "bodrum" && location != "marmaris" && location != "çeşme")
                {
                    Console.WriteLine("Lütfen Bodrum, Marmaris, Çeşme bunlardan birini seçiniz."); // Hatalı seçim yapıldığında çıkan ekran
                }
            } while (location != "bodrum" && location != "marmaris" && location != "çeşme");

            // Kişi sayısı seçim ekranı
                 Console.WriteLine("Kaç kişi tatile gitmek istiyorsunuz?");
                 int count = Convert.ToInt32(Console.ReadLine());

            // Ulaşım Bilgilendirme Ekranı
                 Console.WriteLine("Hangi yol ile gitmek istersiniz?\nKara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)\nHava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
                 string transportation;
            do
            {
                     transportation = Console.ReadLine().ToLower(); // Ulaşım seçim ekranı

                if  (transportation != "kara yolu" && transportation != "hava yolu")
                {
                    Console.WriteLine("Lütfen Kara yolu veya Hava yolu birini seçiniz."); // Hatalı seçim yapıldığında çıkan ekran
                }
            } while (transportation != "kara yolu" && transportation != "hava yolu");

            // Seçilen bilgilerin kullanıcıya sunulduğu ekran
                 Console.WriteLine("Gitmek istediğiniz yer: " + location);
                 Console.WriteLine("Kişi sayısı: " + count);
                 Console.WriteLine("Seçtiğiniz yol: " + transportation);

            // Tatil hakkında bilgi
            switch (location)
            {
                case "bodrum": // Bodrum seçilirse gelen ekran
                    Console.WriteLine("Bodrum tatilinde yapabilecekleriniz:");
                    Console.WriteLine("- Plajlar: Bodrum'un mavi bayraklı plajlarında denize girebilirsiniz.");
                    Console.WriteLine("- Su Sporları: Bodrum'da çeşitli su sporlarını deneyebilirsiniz.");
                    Console.WriteLine("- Tarihi Yerler: Bodrum Kalesi, Antik Tiyatro ve Sualtı Arkeoloji Müzesi'ni gezebilirsiniz.");
                    Console.WriteLine("- Alışveriş: Bodrum çarşılarında alışveriş yapabilirsiniz.");
                    Console.WriteLine("- Gece Hayatı: Bodrum'un ünlü gece kulüplerinde eğlenebilirsiniz.");
                    break;

                case "marmaris": // Marmaris seçilirse gelen ekran
                    Console.WriteLine("Marmaris tatilinde yapabilecekleriniz:");
                    Console.WriteLine("- Plajlar: İçmeler Plajı ve Marmaris Plajı'nda denizin tadını çıkarabilirsiniz.");
                    Console.WriteLine("- Tekne Turları: Marmaris'te çeşitli tekne turlarına katılabilirsiniz.");
                    Console.WriteLine("- Tarihi Yerler: Marmaris Kalesi ve Arkeoloji Müzesi'ni gezebilirsiniz.");
                    Console.WriteLine("- Doğa Yürüyüşleri: Marmaris'in doğal güzelliklerinde yürüyüş yapabilirsiniz.");
                    Console.WriteLine("- Gece Hayatı: Marmaris Barlar Sokağı'nda gece hayatının tadını çıkarabilirsiniz.");
                    break;

                case "çeşme": // Çeşme secilirse gelen ekran
                    Console.WriteLine("Çeşme tatilinde yapabilecekleriniz:");
                    Console.WriteLine("- Plajlar: Alaçatı ve Ilıca plajlarında denizin tadını çıkarabilirsiniz.");
                    Console.WriteLine("- Rüzgar Sörfü: Alaçatı'da rüzgar sörfü yapabilirsiniz.");
                    Console.WriteLine("- Tarihi Yerler: Çeşme Kalesi ve çevresindeki tarihi yerleri gezebilirsiniz.");
                    Console.WriteLine("- Yerel Lezzetler: Çeşme'nin lezzetli deniz ürünlerini ve Ege mutfağını tadabilirsiniz.");
                    Console.WriteLine("- Gece Hayatı: Çeşme'de çeşitli barlar ve gece kulüpleri ile hareketli bir gece hayatının tadını çıkarabilirsiniz.");
                    break;
            }

            // Tatil maliyetlerinin hesaplanması
                 int locationCostPerPerson = 0;
                 int transportationCostPerPerson = 0;

            // Seçilen yere göre tatil maliyeti
            switch (location)
            {
                case "bodrum":
                    locationCostPerPerson = 40000;
                    break;
                case "marmaris":
                    locationCostPerPerson = 30000;
                    break;
                case "çeşme":
                    locationCostPerPerson = 50000;
                    break;
            }

            // Seçilen ulaşım türüne göre ulaşım maliyeti
            switch (transportation)
            {
                case "kara yolu":
                    transportationCostPerPerson = 3000;
                    break;
                case "hava yolu":
                    transportationCostPerPerson = 6000;
                    break;
            }
            // Seçilen yer ve ulaşımın hesaplanmasının yapıldıgı kod
                 int totalTransportationCost = transportationCostPerPerson * count;
                 int totalLocationCost = locationCostPerPerson * count;
                 int totalCost = totalLocationCost + totalTransportationCost;

            // Toplam maliyetin hesaplanması ve kullanıcıya gösterilmesi
                 Console.WriteLine("Toplam tatil maliyetiniz:");
                 Console.WriteLine("Yer: " + totalLocationCost + " TL");
                 Console.WriteLine("Ulaşım: " + totalTransportationCost + " TL");
                 Console.WriteLine("Toplam: " + totalCost + " TL");

            // Başka bir tatil planlamak isteyip istemediğini sorma
                 Console.WriteLine("Başka bir tatil planlamak ister misiniz? (Evet/Hayır)");
                 string response = Console.ReadLine().ToLower();
            if (response != "evet")
            {
                 continuePlanning = false;
                 Console.WriteLine("İyi günler.");
            }
        }
