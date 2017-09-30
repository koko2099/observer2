using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer2 {
  class Program {
    static void Main( string[ ] args ) {

      Subject subject = new ConcreteSubject( );
      Observer obs = new Observer( "Lily" );
      Observer obs1 = new Observer( "May" );
      subject.addObserver( obs );
      subject.addObserver( obs1 );
      subject.doSomething( );

      Console.ReadLine( );

    }
  }
}
