#include <iostream>
using namespace std;
void function(int arr[]);
void function1(int *arr);
main()
{
    int x=25;
    int *ptr;
    ptr=&x;
    cout<<"The value of x is "<<x<<endl;
    cout<<"The value of x is "<<*ptr<<endl;
    *ptr=100;
    cout<<x<<endl;
    cout<<*ptr<<endl;
    int *point;
    int arr[5]={2,4,5,67,7};
    point=arr;
    cout<<point<<endl;
    cout<<*point<<endl;
    cout<<*(point+2)<<endl;
    cout<<arr<<endl;
    cout<<*arr<<endl;
    cout<<*(arr+2)<<endl;
    cout<<*arr+2<<endl;
    int arr1[3]={4,7,11};
    int *point1;
    point1=arr1;
    point1 += 2;
    cout<<point1-arr1; //addresses subtract (index hi ata hai)
    for(int i=0;i<5;i++)
    {
        cout<<*point<<" "<<endl;
        point++;
    }
     for(int i=0;i<5;i++)
    {
        point--;
        cout<<*point<<" "<<endl;
    }
    

}
// {
//     int arr[5]={2,4,5,67,7};
//     cout<<arr<<endl;
//     function(arr);
//     function1(arr);
// }
// void function(int arr[])
// {
//     for(int i=0;i<5;i++)
//     {
//         cout<<arr[i]<<" "<<endl;
//     }
// }
// void function1(int *arr)
// {
//     for(int i=0;i<5;i++)
//     {
//         cout<<arr[i]<<" "<<endl;
//     }
// }