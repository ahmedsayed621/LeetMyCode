class slot
        {
            public long start { get; set; }
            public long end { get; set; }
        }

public class MyCalendar {

     slot[] m_slots;
            int used = 0;
    
    public MyCalendar() {
         m_slots = new slot[1000];
    }
    
    public bool Book(int start, int end) {
          slot input = new slot() { start = start, end = end };
                bool bookable = true;

                for (int i = 0; i < used; i++)
                {
                    if (end <= m_slots[i].start || start >= m_slots[i].end)
                    {
                        continue;
                    }
                    else {
                        bookable = false;
                        break;
                    }
                }

                if (bookable)
                {
                    m_slots[used++] = input;
                }

                return bookable;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */