import java.util.concurrent.CyclicBarrier;

public class Threads
{
  public static class DelayedMessagePrinter implements Runnable
  {
    private volatile CyclicBarrier barrier;
    private volatile String msg;

    public DelayedMessagePrinter(CyclicBarrier barrier, String msg)
    {
      this.barrier = barrier;
      this.msg = msg;
    }

    public void run()
    {
      try
      {  barrier.await();  }
      catch (Exception e)
      {  }
      System.out.println(msg);
    }
  }

  public static void main(String[] args)
  {
    CyclicBarrier barrier = new CyclicBarrier(3);
   
    for ( int i = 0; i < 1000000; ++i ) {	
	new Thread(new DelayedMessagePrinter(barrier, "Enjoy")).start();
    	new Thread(new DelayedMessagePrinter(barrier, "Rosetta")).start();
    	new Thread(new DelayedMessagePrinter(barrier, "Code")).start();
    }
  }
}
