using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Car
    {
        private static string _production { get; set; }
        private static string _brand { get; set; }
        private string _model { get; set; }

        private string _color { get; set; }
        private double _price { get; set; }
        private int _year { get; set; }
        private string _transmission { get; set; }

        private int _changeParameter { get; set; }

        public void Information()
        {
            Console.WriteLine("Введите страну-производителя машины");
            _production = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Введите марку  желаемой Вами машины");
            _brand = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Введите модель  желаемой Вами машины");
            _model = Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Введите желаемый цвет");
            _color = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Введите сумму, которую Вы готовы внести для оплаты");
            _price = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Год выпуска");
            _year = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Выберите:автомат или механика");
            _transmission = Console.ReadLine();
            

            
            Console.Clear();


            
        }
        public void ShowInformation()
        {
            Console.WriteLine("Страна: " + _production);

            Console.WriteLine("Марка: " +_brand);

            Console.WriteLine("Модель: " + _model);

            Console.WriteLine("Цвет: " + _color);

            Console.WriteLine("Сумма внесения: " + _price);

            Console.WriteLine("Год выпуска: " + _year);

            Console.WriteLine("Коробка: " + _transmission);

          


        }

        public void ChangeAnyParameter()
        {
            Console.WriteLine("Для изменения чего-либо нажмите 1. Для выхода нажмите Enter");
            _changeParameter = int.Parse(Console.ReadLine());
            Console.Clear();
            if (_changeParameter==1)
            {
                Console.WriteLine("Что вы хотите изменить?");
                Console.WriteLine("1)Выбрать другую машину");
                Console.WriteLine("2)Выбрать другую марку машины");
                Console.WriteLine("3)Выбрать другую модель машины");
                Console.WriteLine("4)Выбрать другой цвет машины");
                Console.WriteLine("5)Внести другую сумму");
                Console.WriteLine("6)Выбрать другой год выпуска");
                Console.WriteLine("7)Выбрать другую коробку");
                _changeParameter = int.Parse(Console.ReadLine());

                if(_changeParameter==1)
                {
                    Console.WriteLine("Введите страну-производителя машины");
                    _production = Console.ReadLine();
                    

                    Console.WriteLine("Введите марку  желаемой Вами машины");
                    _brand = Console.ReadLine();
                    

                    Console.WriteLine("Введите модель  желаемой Вами машины");
                    _model = Console.ReadLine();
                    


                    Console.WriteLine("Введите желаемый цвет");
                    _color = Console.ReadLine();
                    

                    Console.WriteLine("Введите сумму, которую Вы готовы внести для оплаты");
                    _price = double.Parse(Console.ReadLine());
                   
                    Console.WriteLine("Год выпуска");
                    _year = int.Parse(Console.ReadLine());
                    

                    Console.WriteLine("Выберите:автомат или механика");
                    _transmission = Console.ReadLine();
                    Console.Clear();
                }
                if (_changeParameter==2)
                {
                    

                    Console.WriteLine("Введите марку  желаемой Вами машины");
                    _brand = Console.ReadLine();
                    

                    Console.WriteLine("Введите модель  желаемой Вами машины");
                    _model = Console.ReadLine();
                    


                    Console.WriteLine("Введите желаемый цвет");
                    _color = Console.ReadLine();
                    

                    Console.WriteLine("Введите сумму, которую Вы готовы внести для оплаты");
                    _price = double.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Год выпуска");
                    _year = int.Parse(Console.ReadLine());
                    

                    Console.WriteLine("Выберите:автомат или механика");
                    _transmission = Console.ReadLine();
                    Console.Clear();
                }
                if (_changeParameter==3)
                {
                    

                    

                    Console.WriteLine("Введите модель  желаемой Вами машины");
                    _model = Console.ReadLine();
                    


                    Console.WriteLine("Введите желаемый цвет");
                    _color = Console.ReadLine();
                    

                    Console.WriteLine("Введите сумму, которую Вы готовы внести для оплаты");
                    _price = double.Parse(Console.ReadLine());
                   
                    Console.WriteLine("Год выпуска");
                    _year = int.Parse(Console.ReadLine());
                   

                    Console.WriteLine("Выберите:автомат или механика");
                    _transmission = Console.ReadLine();
                    Console.Clear();
                }
                if (_changeParameter==4)
                {
                   


                    Console.WriteLine("Введите желаемый цвет");
                    _color = Console.ReadLine();
                    Console.Clear();

                    
                    

                    
                }
                if (_changeParameter==5)
                {
                   

                    
                    Console.WriteLine("Введите сумму, которую Вы готовы внести для оплаты");
                    _price = double.Parse(Console.ReadLine());
                    Console.Clear();
                   

                    
                }
                if (_changeParameter ==6)
                {
                    
                    Console.WriteLine("Год выпуска");
                    _year = int.Parse(Console.ReadLine());
                    Console.Clear();

                    
                }
                if (_changeParameter==7)
                {
                    

                    Console.WriteLine("Выберите:автомат или механика");
                    _transmission = Console.ReadLine();
                    Console.Clear();
                }
                ShowInformation();
                Console.ReadKey();
            }

            
            




            

            

            
        }

    }
}
