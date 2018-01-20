#include <thread>
#include <iostream>
#include <vector>
#include <random>
#include <chrono> 


int executeTask(int i) {
  std::random_device rd;
  std::mt19937 eng(rd()); // mt19937 generator with a hardware random seed.
  std::uniform_int_distribution<> dist(1,2);
  std::vector<std::thread> threads;
 
  for(const auto& str: {"Enjoy\n", "Rosetta\n", "Code\n"}) {
    std::chrono::milliseconds duration(dist(eng)); 
   
    threads.emplace_back([str, duration](){                                                                    
      std::this_thread::sleep_for(duration);
      std::cout  << str;
    });
  }
 
  for(auto& t: threads) t.join(); 
  return i;
}

int main()
{
	volatile int r = 1;
	for (int i = 0; i < 1000000; ++i) {
		r = executeTask(i + r);
	}
  return 0;
}
