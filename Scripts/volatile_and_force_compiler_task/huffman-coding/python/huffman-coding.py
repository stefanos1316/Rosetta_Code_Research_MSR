from heapq import heappush, heappop, heapify
from collections import defaultdict

def encode(symb2freq):
    """this is an example for huffman encoding"""
    heap = [[wt, [sym, ""]] for sym, wt in symb2freq.items()]
    heapify(heap)
    while len(heap) > 1:
        lo = heappop(heap)
        hi = heappop(heap)
        for pair in lo[1:]:
            pair[1] = '0' + pair[1]
        for pair in hi[1:]:
            pair[1] = '1' + pair[1]
        heappush(heap, [lo[0] + hi[0]] + lo[1:] + hi[1:])
    return sorted(heappop(heap)[1:], key=lambda p: (len(p[-1]), p))

r = 1

def executeTask(i): 
    txt = "this is an example for huffman encoding" +`i`
    symb2freq = defaultdict(int)
    for ch in txt:
        symb2freq[ch] += 1
    huff = encode(symb2freq)
    return i + 1


for i in range(1000000):
 	r = executeTask(i)
