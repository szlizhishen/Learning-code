//����������һ���������У��������е�������˳����б������õ���һ��������ǰ�������£�
//1.     1
//2.     11
//3.     21
//4.     1211
//5.     111221
//1 ������  "one 1"  ("һ��һ") , �� 11��
//11 ������ "two 1s" ("����һ"��, �� 21��
//21 ������ "one 2",  "one 1" ��"һ����" ,  "һ��һ") , �� 1211��
//����һ�������� n��1 �� n �� 30��������������еĵ� n �
//ע�⣺����˳�򽫱�ʾΪһ���ַ�����
class Solution {
public:
    string countAndSay(int n) {
        string a="1",temp="";
        for(int i=1;i<n;i++)
        {
            int t=0;
              while(t<a.size())
            {
                int value=1;
                while(a[t]==a[t+1])//&&t+1<a.size()
                {
                    value++;
                    t++;
                }
                temp=temp+to_string(value)+a[t];//char����ֱ�ӣ�����to_string
                t++;
            }
            a=temp;
            temp="";
        }
        return a;
    }

};