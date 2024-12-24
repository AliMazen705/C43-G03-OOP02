using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
		#region full
		//private int id;

		//public int Id
		//{
		//	get { return id; }
		//	set { id = value; }
		//}

		//private int model;

		//public int Model
		//{
		//	get { return model; }
		//	set { model = value; }
		//}

		//private int speed;

		//public int Speed
		//{
		//	get { return speed; }
		//	set { speed = value; }
		//}
		#endregion

		#region Attributes
		//public int id { get; set; }
		//public string model { get; set; }
		//public double speed { get; set; }
        #endregion

		//constructor chainning
		//public Car(int Id, string Model, double Speed)
		//{
  //          Console.WriteLine("cons 01");
		//	this.id = Id;
		//	this.model = Model;
		//	this.speed = Speed;
		//}

		//public Car(int _Id,string _Model) :this(_Id, _Model,150) 
		//{
  //          Console.WriteLine("cons 02");
		//	//id = _Id;
		//	//model = _Model;

		//}
		//public Car(int _Id):this(_Id,"Kia",200)
		//{
  //          Console.WriteLine("cons 03");

		//}
        #region method
        //public override string ToString()
        //{
        //    return $"Car Id={id}\n Model is {model}\n Speed = {speed}";
        //}
        #endregion


    }
}
