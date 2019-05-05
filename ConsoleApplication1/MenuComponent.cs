using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        public virtual string GetName()
        {
            throw new NotSupportedException();
        }

        public virtual string GetDescription()
        {
            throw new NotSupportedException();
        }

        public virtual double GetPrice()
        {
            throw new NotSupportedException();
        }

        public virtual bool IsVegetarian()
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }

        public virtual IEnumerator CreateIterator()
        {
            throw new NotSupportedException();
        }
    }

    class MenuItem : MenuComponent
    {
        string _name;
        string _description;
        bool _isVegetarian;
        double _price;

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            _name = name;
            _description = description;
            _isVegetarian = isVegetarian;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override double GetPrice()
        {
            return _price;
        }

        public override bool IsVegetarian()
        {
            return _isVegetarian;
        }

        public override void Print()
        {
            Console.Write(GetName());
            if (IsVegetarian())
            {
                Console.Write(" (v)");
            }
            Console.WriteLine(" " + GetPrice());
            Console.WriteLine(GetDescription());
        }
    }

    class Menu : MenuComponent
    {
        string _name;
        string _description;
        ArrayList _menuComponents = new ArrayList();

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return (MenuComponent)_menuComponents[i];
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Print()
        {
            Console.Write(GetName());
            Console.WriteLine(", " + GetDescription());
            Console.WriteLine("---------------------------------");

            IEnumerator enumerator = _menuComponents.GetEnumerator();
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                menuComponent.Print();
            }
        }

        public override IEnumerator CreateIterator()
        {
            return new CompositeIterator(_menuComponents.GetEnumerator());
        }
    }

    class Waitress
    {
        MenuComponent _menuComponent;

        public Waitress(MenuComponent menuComponent)
        {
            _menuComponent = menuComponent;
        }

        public void Print()
        {
            _menuComponent.Print();
        }

        public void PrintVegetarianMenu()
        {
            IEnumerator enumerator = _menuComponent.CreateIterator();
            Console.WriteLine("\nVegetarain Menu\n-----------------");
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                try
                {
                    if (menuComponent.IsVegetarian())
                        menuComponent.Print();
                }
                catch(NotSupportedException e)
                {

                }
            }
        }
    }

    class MenuTest
    {
        static void Main()
        {
            MenuComponent pancakeHouceMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinnerMenu = new Menu("DINNER MENU", "DINNER");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "SNACKS");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert Course");

            MenuComponent allMenu = new Menu("All Menu", "All menus combined");

            allMenu.Add(pancakeHouceMenu);
            allMenu.Add(dinnerMenu);
            allMenu.Add(cafeMenu);

            dinnerMenu.Add(new MenuItem("Pasta","",true,3.89));
            dinnerMenu.Add(dessertMenu);
            dessertMenu.Add(new MenuItem("Apple Pie","",true,1.59));

            Waitress waitress = new Waitress(allMenu);
            waitress.Print();
            waitress.PrintVegetarianMenu();


            Console.ReadKey();
        }
    }

    public class CompositeIterator:IEnumerator
    {
        Stack stack = new Stack();

        public CompositeIterator(IEnumerator enumerator)
        {
            stack.Push(enumerator);
        }

        public object Current 
        {
            get 
            {
                if (MoveNext())
                {
                    IEnumerator enumerator = (IEnumerator)stack.Peek();
                    MenuComponent component = (MenuComponent)enumerator.Current;
                    if (component is Menu)
                        stack.Push(component.CreateIterator());
                    return component;
                }
                else
                {
                    return null;
                }
            } 
        }

        public bool MoveNext()
        {
            if (stack.Count == 0)
                return false;
            else
            {
                IEnumerator enumerator = (IEnumerator)stack.Peek();
                if (!enumerator.MoveNext())
                {
                    stack.Pop();
                    return MoveNext();
                }
                else
                {
                    return true;
                }
            }
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }
    }
}
