#include <iostream>
#include <fstream>
#include <string>
#include <sstream>

using namespace std;

int executeTask(int i) {

    string line;
    string s = to_string(i);
    stringstream ss;
    ss << "../test_directory/" << s;
    string fileLocation = ss.str();    

    ifstream input (fileLocation);
    ofstream output ("output.txt");
    if (output.is_open()) {
        if (input.is_open()){
            while (getline (input,line)) {
                output << line << endl;
            }
            input.close(); // Not necessary - will be closed when variable goes out of scope.
        }
        else {
            cout << "input.txt cannot be opened!\n";
        }
        output.close(); // Not necessary - will be closed when variable goes out of scope.
    }
    else {
        cout << "output.txt cannot be written to!\n";
    }

	return i + 1;
}

int main() {
	
	volatile int r = 1;
	for ( int i = 1; i <= 10000; ++i ) {
		r = executeTask(i);
	}
    return 0;
}
