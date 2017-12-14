using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo_01_Basic.Tests
{
    public interface IShape
    {
        string Name { get; set; }
        void Draw(); 
        decimal CalculateArea();
    }

    public interface IStore
    {
        string ID { get; set; }
    }

    public interface IGuiShape : IShape, IStore
    {
        void ShowOnForm();
    }


    public class Test : IGuiShape
    {
        public string Name { get; set; }
        public string ID { get; set; }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void ShowOnForm()
        {
            throw new NotImplementedException();
        }
    }
}
