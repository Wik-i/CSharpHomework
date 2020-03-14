using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication {

  // 链表节点
  public class Node<T> {
    public Node<T> Next { get; set; }
    public T Data { get; set; }

    public Node(T t) {
      Next = null;
      Data = t;
    }
  }

  //泛型链表类
  public class GenericList<T> {
    private Node<T> head;
    private Node<T> tail;

    public GenericList() {
      tail = head = null;
    }

    public Node<T> Head {
      get => head;
    }

    public void Add(T t) {
      Node<T> n = new Node<T>(t);
      if (tail == null) {
        head = tail = n;
      }else {
        tail.Next = n;
        tail = n;
      }
    }

    public void ForEach(Action<T> fun){
            Node<T> ptr = this.head;
            //Node <T> ptr=head.Next;
            while(ptr!=null){
                fun(ptr.Data);
                ptr=ptr.Next;
            }
    }

  }

  class Program {
    static void Main(string[] args) {
      

      // 整型List
      GenericList<int> intlist = new GenericList<int>();
      for (int x = 0; x < 10; x++) {
        intlist.Add(x);
      }
      for (Node<int> node = intlist.Head; 
            node != null; node = node.Next) {
        Console.WriteLine(node.Data);
      }
      //循环展示
      intlist.ForEach(x=>Console.Write(x));
      //通过ForEach（）寻找最大值
      int max=intlist.Head.Data;
      intlist.ForEach(x=>max=x>max?x:max);
      Console.Write("\nthe max in the list is :"+max+"\n");
      //求最小值
      int min =intlist.Head.Data;
      intlist.ForEach(x=>min=x<min?x:min);
      Console.Write("\nthe min in the list is :"+min+"\n");
      //求和
      int sum=0;
      intlist.ForEach(x=>sum+=x);
      Console.Write("\nthe sum of the list is:"+sum+"\n");


      // 字符串型List
      GenericList<string> strList = new GenericList<string>();
      for (int x = 0; x < 10; x++) {
        strList.Add("str"+x);
      }
      for (Node<string> node = strList.Head; 
              node != null; node = node.Next) {
        Console.WriteLine(node.Data);
      }

      Console.ReadLine();
      Console.ReadLine();

    }

  }
}