/* Question 16.5
 
Suppose we have the following code:
public class Foo {
    public Foo() {  }
    public void First() {  }
    public void Second() {  }
    public void Third() {  }
}
The same instance of Foo will be passed to three different threads. ThreadA will call first, 
threadB will call second, and threadC will call third. Design a mechanism to ensure that first
is called before second and second is call before third.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter16_Q05
    {
    }
}
