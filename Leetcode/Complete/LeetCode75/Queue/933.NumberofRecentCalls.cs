using System.Diagnostics;
// You have a RecentCounter class which counts the number of recent requests within a certain time frame.

// Implement the RecentCounter class:
//     - RecentCounter() Initializes the counter with zero recent requests.
//     - int ping(int t) Adds a new request at time t, where t represents some time in milliseconds, 
//       and returns the number of requests that has happened in the past 3000 milliseconds (including the new request).
//       Specifically, return the number of requests that have happened in the inclusive range [t - 3000, t].

// It is guaranteed that every call to ping uses a strictly larger value of t than the previous call.

public class RecentCounter
{
	// create int queue
	private Queue<int> queue;

	// init the queue on instantiation
	public RecentCounter()
	{
		queue = new Queue<int>();
	}


	public int Ping(int t)
	{
		// add to queue each ping
		queue.Enqueue(t);

		// dequeue oldest if more than t - 3000ms  
		while (queue.Peek() < t - 3000)
			queue.Dequeue();

		// return number of elements within 3000ms 
		return queue.Count;
	}
}
