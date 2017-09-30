using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer2 {
  public abstract class Subject {
    private List<Observer> obsList = new List<Observer>( );

    public void addObserver(Observer ob ) {
      obsList.Add( ob );
    }

    public void delObserver(Observer ob ) {
      obsList.Remove( ob );
    }

    public void NotifyObserver( ) {
      foreach( var o in obsList ) {
        o.Update( );
      }
    }

    public abstract void doSomething( );
  }

  public class ConcreteSubject :Subject{
    public override void doSomething( ) {
      Console.WriteLine( "ConcreteSubject doing..." );
      base.NotifyObserver( );
    }

  }


  // --------------------- 观察者
  public class Observer {
    public string Name { get; set; }
    public Observer(string name ) {
      Name = name;
    }
    public void Update( ) {
      Console.WriteLine( $"{Name} Observer update..." );
    }
  }
}
