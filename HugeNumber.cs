using System;

namespace ConsoleApplication1
{

    public class HugeNumber
    {
        public int carry;
        public int count;
        public Node newNode;
        public Node start;
        public Node end;
        public Node current;

        public HugeNumber()
        {
            carry = 0;
            count = 0;
            start = null;
            end = null;
            current = null;
            //newNode = new Node();
        }

        public int getCarry()
        {
            return carry;
        }
        public void setCarry(int carry)
        {
            this.carry = carry;
        }
        public Node getStart()
        {
            return start;
        }
        public void setStart(Node start)
        {
            this.start = start;
        }
        public Node getEnd()
        {
            return end;
        }
        public void setEnd(Node end)
        {
            this.end = end;
        }
        public void addDidit(int value)
        {
            newNode = new Node();
            newNode.Value = value;

            if (start == null)
            {
                start = newNode;
                end = newNode;
            }
            else
            {
                newNode.PrevNode = end;
                end.NextNode = newNode;
                end = newNode;
            }
            count++;

        }
        public void removeDigit()
        {
            if (start.NextNode == null)
            {
                start = null;
                end = null;
            }
            else
            {
                end = end.PrevNode;
                end.NextNode = null;
            }
            count--;
        }
        public HugeNumber addNumbers(HugeNumber number1, HugeNumber number2)
	{
		int _sum = 0;
		HugeNumber sum = new HugeNumber();
		
		int difference = 0 ;
        if (number1.count > number2.count)
        {
            difference = number1.count - number2.count;
            for (int i = difference; i >= 1; i--)
            {
                number2.newNode = new Node();
                number2.newNode.Value = 0;
                number2.start.PrevNode = number2.newNode;
                number2.newNode.NextNode = number2.start;
                number2.start = number2.newNode;
                number2.count++;
            }
        }
        else
        {
            difference = number2.count - number1.count;
            for (int i = difference; i >= 1; i--)
            {
                number1.newNode = new Node();
                number1.newNode.Value = 0;
                number1.start.PrevNode = number1.newNode;
                number1.newNode.NextNode = number1.start;
                number1.start = number1.newNode;
                number1.count++;
            }
        }	
		
		
		number1.current = number1.end;
		number2.current = number2.end;
		carry = 0;
		
		
		while(number1.current != null)
		{
			_sum = number1.current.Value + number2.current.Value + carry;
			
			
			
			if(_sum > 9)
			{
				carry = 1;				
			}
			else
			{
				carry = 0;
			}
			sum.newNode = new Node();
			sum.newNode.Value = _sum % 10;
			if(sum.start == null)
			{
				sum.start = sum.newNode;
				sum.end = sum.newNode;
			}
			else
			{				
				sum.start.PrevNode = sum.newNode;
				sum.newNode.NextNode = sum.start;
				sum.start = sum.newNode;
			}
            sum.count++;
			
			number1.current = number1.current.PrevNode;
			number2.current = number2.current.PrevNode;			
				
		}
        if (carry == 1)
        {
            sum.newNode = new Node();
            sum.newNode.Value = 1;
            sum.start.PrevNode = sum.newNode;
            sum.newNode.NextNode = sum.start;
            sum.start = sum.newNode;
        }
        //sum.current = sum.start;
		
        //while(sum.current!=null)
        //{
        //    Console.WriteLine(sum.current.Value);
        //    sum.current = sum.current.NextNode;
        //}
		
		return sum;
	}
    }
















}
