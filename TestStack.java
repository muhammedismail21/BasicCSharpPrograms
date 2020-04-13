using System;
class TestStack 
{

	public static void main(String[] args) 
	{

		Stack _stack = new Stack();
		_stack.Push(2);
		_stack.Push(38);
		_stack.Push(45);
		_stack.Push(60);
		_stack.Push(17);
		
		for (int i = 0; i < _stack.StackElements.Length; i++) 
		{
			Console.WriteLine(_stack.StackElements[i]);
		}

	}

}
