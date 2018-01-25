import java.util.concurrent.CyclicBarrier;

public class Threads
{
  
  private static volatile int r = 0;
  
  public static class DelayedMessagePrinter implements Runnable
  {
    private volatile CyclicBarrier barrier;
    private volatile String msg;
    private volatile int i;
	
    public DelayedMessagePrinter(CyclicBarrier barrier, String msg, int i)
    {
      this.barrier = barrier;
      this.msg = msg;
      this.i = i;
    }

    public void run()
    {
      try
      {  barrier.await();  }
      catch (Exception e)
      {  }
      System.out.println(i + " " + msg);
    }
  }

  public static int executeTask(int i ) {

        CyclicBarrier barrier = new CyclicBarrier(3);
	new Thread(new DelayedMessagePrinter(barrier, "Enjoy", i)).start();
    	new Thread(new DelayedMessagePrinter(barrier, "Rosetta", i)).start();
    	new Thread(new DelayedMessagePrinter(barrier, "Code", i)).start();
	return i;
  }

  public static void main(String[] args)
  {
  
    for ( int i = 0; i < 1000000; ++i ) {	
	r = executeTask(i + r);  
  }
  }
}
