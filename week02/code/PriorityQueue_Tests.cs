using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items: (“A”, 1), (“B”, 10), (“C”, 5), then deque all
    // Expected Result: Items come out in order: B, C, A
    // Scenario: Enqueue four items: ("X", 3), ("Y", 5), ("Z", 5), ("W", 1), then dequeue all.
    // Expected Result: Items come out in order: Y, Z, X, W (highest priority first; ties follow FIFO order)

    //Defects Found:
    // 1. The Dequeue function was not removing items, so previously dequeued items could be returned again.
    // 2. When priorities were equal, the wrong item was sometimes removed (did not follow FIFO for same-priority items).

    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 10);
        priorityQueue.Enqueue("C", 5);
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue four items: ("X", 3), ("Y", 5), ("Z", 5), ("W", 1), then dequeue all.
    // Expected Result: Items come out in order: Y, Z, X, W (highest priority first; ties follow FIFO order)
    // Defect(s) Found: 

    // 1. The Dequeue function was not removing items, so previously dequeued items could be returned again.
    // 2. When priorities were equal, the wrong item was sometimes removed (did not follow FIFO for same-priority items).
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("X", 3);
        priorityQueue.Enqueue("Y", 5);
        priorityQueue.Enqueue("Z", 5);
        priorityQueue.Enqueue("W", 1);
        Assert.AreEqual("Y", priorityQueue.Dequeue());
        Assert.AreEqual("Z", priorityQueue.Dequeue());
        Assert.AreEqual("X", priorityQueue.Dequeue());
        Assert.AreEqual("W", priorityQueue.Dequeue());
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: InvalidOperationException is thrown.
    // Defect(s) Found: None
    public void TestPriorityQueue_EmptyDequeue()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();// This should throw an exception since the queue is empty.
    }

}