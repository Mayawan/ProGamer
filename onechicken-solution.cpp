#include <iostream>

using namespace std;

int main() {
  int n,m;
  cin >> n >> m;

    if(m - n == 1)
    {
      cout << "Dr. Chaz will have " << m - n << " piece of chicken left over!" << endl;
    }
    else if(m - n == -1)
    {
      cout << "Dr. Chaz needs " << n - m << " more piece of chicken!" << endl;
    }
    else if(m - n > 0)
    {
    cout << "Dr. Chaz will have " << m - n << " pieces of chicken left over!" << endl;
    }
    else
    {
      cout << "Dr. Chaz needs " << n - m << " more pieces of chicken!" << endl;
    }
}
