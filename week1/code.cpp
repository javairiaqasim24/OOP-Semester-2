#include <iostream>
using namespace std;
int option();
main()
{
    int amountDeposit,amountWithdraw,loan;
    int opt=option();
    int zakat(int amountDeposit);
    if(opt==1)
    {
        cout<<"Enter Amount you want to deposit :";
        cin>>amountDeposit;
        if(amountDeposit==50000)
        {
            amountDeposit= (amountDeposit-(amountDeposit*0.025));
        }
    }
    if(opt==2)
    {
        cout<<"Enter Amount you want to Withdraw :";
        cin>>amountWithdraw;
    }
    if(opt==3)
    {
        cout<<"Enter Amount of loan :";
        cin>>loan;
    }

}
int option()
{
    int opt;
    cout<<"1.Deposit";
    cout<<"2.Withdraw";
    cout<<"3.Get loan";
    cout<<"Enter option : ";
    cin>>opt;
    return opt;
}
int zakat(int amountDeposit)
{
    int zakat;
    zakat=(amountDeposit-(amountDeposit*0.025));
}
