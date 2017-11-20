
# coding: utf-8

# ### 

# In[73]:


import pandas as pd
import seaborn as sns
import sys
import matplotlib.pyplot as plt
import numpy as np
import re
import matplotlib.colors as mcolors
from os import environ

#All environmental variables are located here
index = environ['myvar']
numberOfTasks = int(environ['noTasks']) + 0
numberOfLanguages = int(environ['noLanguages']) + 0
totalFields = numberOfTasks*numberOfLanguages
tasksNames = environ['allTasksNames']
tasksNames = tasksNames.split(",")
fileLocation = environ['fileLocation']
fullPath = fileLocation + "Normalized_EDP_" + index + ".txt"
#Initializing Arrays
langaugesEDP=[""  for x in xrange(totalFields)]
ProgrammingLanguages=[""  for x in xrange(totalFields)]
ProgrammingTasks=[""  for x in xrange(totalFields)]
langaugeArray=['C#', 'C', 'C++', 'Go', 'JavaScript', 'Java', 'Perl', 'PHP', 'Python', 'R', 'Ruby', 'Rust', 'Swift', 'VB.Net']
#taskArray=['ackermann','array-concat', 'call-obj-method', 'classes','concurrent-comp.','factorial','file-I/O', 'huffman', 'inherit,-multi.','inherit.-single','json','palindrome','regex','bubble-sort','insertion-sort','merge-sort','quick-sort','selection-sort','url-decoding','url-encoding']
counter=0      

#Read files and fill tables with ata
with open(fullPath) as f:
#with open('/home/sgeorgiou/GitHub/Rosetta_Code_Research_MSR/Reports/Experiment_Data_Thu__2_Nov_09:17:53_UTC_2017/GraphData/Normalized_EDP_'+ index +'.txt') as f:
    for line in f:
        line = line.replace(":","")
        line = line.replace(",","")
        data = re.split('\s+', line)
        data.pop(0)
        for i in range(numberOfLanguages):
            langaugesEDP[counter] = float(data[i])
            counter += 1
            
correctlySortedEDP=[[0 for x in range(numberOfTasks)] for y in range(numberOfLanguages)] 
for i in range(numberOfLanguages):
    for j in range (numberOfTasks):
        correctlySortedEDP[i][j] = langaugesEDP[i+(j*14)]
 

#Creating a dummy array that includes all the average EDP for languages
dummyArray=[0 for x in range(numberOfLanguages)]
dummyNotSortedArray=[0 for x in range(numberOfLanguages)]
divideWith=0
average=0
for i in range(numberOfLanguages):
    for j in range (numberOfTasks):
        if correctlySortedEDP[i][j] != -1:
            average += correctlySortedEDP[i][j]
            divideWith += 1
    dummyArray[i]= average/divideWith
    divideWith=0
    average=0
for k in range(numberOfLanguages):
    dummyNotSortedArray[k] = dummyArray[k]
dummyArray.sort()

#Here we reodreder to EDP results based on the lowest avereage EDP for the languages    
total=0
average=0
divideWith=0
reorderindSortedEDPList=[[0 for x in range(numberOfTasks)] for y in range(numberOfLanguages)]   
for i in range(numberOfLanguages):
    for j in range (numberOfTasks):
        if correctlySortedEDP[i][j] != -1:
            total += correctlySortedEDP[i][j]
            divideWith += 1
    average = total/divideWith
    #print("Programming Language ",langaugeArray[i], " average score in EDP ",average, " and divided with ", divideWith )
    for k in range(numberOfLanguages):
        if dummyArray[k] == average:
            for l in range(numberOfTasks):
               reorderindSortedEDPList[k][l] = correctlySortedEDP[i][l]
    total=0
    divideWith=0   

#Creating a dummy array that includes all the average EDP for tasks
anotherDummyArray=[0 for x in range(numberOfTasks)]
anotherNotSortedDummyArray=[0 for x in range(numberOfTasks)]
average=0
divideWith=0
for i in range(numberOfTasks):
    for j in range(numberOfLanguages):
        if  reorderindSortedEDPList[j][i] != -1:
            average += reorderindSortedEDPList[j][i]
            divideWith += 1
    anotherDummyArray[i] = average/divideWith
    divideWith = 0
    average=0   
for k in range(numberOfTasks):
    anotherNotSortedDummyArray[k] = anotherDummyArray[k]
anotherDummyArray.sort()

#Here we reodreder to EDP results based on the lowest avereage EDP for the tasks
AgainReorderindSortedEDPList=[[0 for x in range(numberOfTasks)] for y in range(14)] 
average=0
divideWith=0
for i in range(numberOfTasks):
    for j in range (numberOfLanguages):
        if  reorderindSortedEDPList[j][i] != -1:
            average += reorderindSortedEDPList[j][i]
            divideWith +=1
    average /= divideWith
    for k in range(numberOfTasks):
        if anotherDummyArray[k] == average:
            for l in range(numberOfLanguages):
               AgainReorderindSortedEDPList[l][k] = reorderindSortedEDPList[l][i]
    average=0
    divideWith=0
    
#Now reoder the programming langauges regarding the average EDP
sortedProgrammingLanguagesBasedOnAverage=['' for x in range(numberOfLanguages)]
for i in range(14):
    for j in range(14):
        if dummyArray[i] == dummyNotSortedArray[j]:
            sortedProgrammingLanguagesBasedOnAverage[i] = langaugeArray[j]

#Now reoder the programming langauges regarding the average EDP
sortedTasksBasedOnAverage=['' for x in range(numberOfTasks)]
for i in range(numberOfTasks):
    for j in range(numberOfTasks):
        if anotherDummyArray[i] == anotherNotSortedDummyArray[j]:
            sortedTasksBasedOnAverage[i] = tasksNames[j]
    
#At this part we are renaming some task so they can fill in the graph.
for i in range(numberOfTasks):
    if "-function" in sortedTasksBasedOnAverage[i]:
        sortedTasksBasedOnAverage[i] = sortedTasksBasedOnAverage[i].replace("-function","")
    if "-concatenation" in sortedTasksBasedOnAverage[i]:
        sortedTasksBasedOnAverage[i] = sortedTasksBasedOnAverage[i].replace("-concatenation","")
    if "sorting-algorithms-" in sortedTasksBasedOnAverage[i]:
        sortedTasksBasedOnAverage[i] = sortedTasksBasedOnAverage[i].replace("sorting-algorithms-","")
    if "-sort" in sortedTasksBasedOnAverage[i]:
        sortedTasksBasedOnAverage[i] = sortedTasksBasedOnAverage[i].replace("-sort","")    
    if "huffman-coding" in sortedTasksBasedOnAverage[i]:
        sortedTasksBasedOnAverage[i] = sortedTasksBasedOnAverage[i].replace("-coding","") 
    if "-detection" in sortedTasksBasedOnAverage[i]:
        sortedTasksBasedOnAverage[i] = sortedTasksBasedOnAverage[i].replace("-detection","")
    if "regular-expressions" in sortedTasksBasedOnAverage[i]:
        sortedTasksBasedOnAverage[i] = sortedTasksBasedOnAverage[i].replace("regular-expressions","regex")
    if "call-an-object-method" in sortedTasksBasedOnAverage[i]:
        sortedTasksBasedOnAverage[i] = sortedTasksBasedOnAverage[i].replace("call-an-object-method","call-obj-method")  
    if "inheritance-single" in sortedTasksBasedOnAverage[i]:
        sortedTasksBasedOnAverage[i] = sortedTasksBasedOnAverage[i].replace("inheritance-single","inherit.-single")    
    if "inheritance-multiple" in sortedTasksBasedOnAverage[i]:
        sortedTasksBasedOnAverage[i] = sortedTasksBasedOnAverage[i].replace("inheritance-multiple","inherit.-multi.")
    if "file-input-output" in sortedTasksBasedOnAverage[i]:
        sortedTasksBasedOnAverage[i] = sortedTasksBasedOnAverage[i].replace("input-output","I/O")
    if "concurrent-computing" in sortedTasksBasedOnAverage[i]:
        sortedTasksBasedOnAverage[i] = sortedTasksBasedOnAverage[i].replace("concurrent-computing","concur.-comp.")


for i in range(numberOfLanguages):
    for j in range (numberOfTasks):
        if AgainReorderindSortedEDPList[i][j] == -1:
            AgainReorderindSortedEDPList[i][j] = np.nan
            
            
#ProgrammingLanguagesReIndex=['C#','C', 'JavaScript','Go', 'C++','VB.NET', 'PHP', 'Rust' , 'Ruby', 'Python', 'Perl', 'Swift', 'Java', 'R']
cmap1 = mcolors.LinearSegmentedColormap.from_list("n",['#00FF00','#12FF00','#24FF00','#35FF00','#47FF00','#58FF00','#6AFF00','#7CFF00','#8DFF00','#9FFF00','#B0FF00','#C2FF00','#D4FF00','#E5FF00','#F7FF00','#FFF600','#FFE400','#FFD300','#FFC100','#FFAF00','#FF9E00','#FF8C00','#FF7B00','#FF6900','#FF5700','#FF4600','#FF3400','#FF2300','#FF1100','#FF0000',
])
plt.figure(figsize=(20, 10))
df = pd.DataFrame( AgainReorderindSortedEDPList, index=sortedProgrammingLanguagesBasedOnAverage, columns=sortedTasksBasedOnAverage)
df.columns.name = 'Programming Languages'
df.columns.font=20
df.index.name = 'Programming Tasks'
mask = df.isnull()
sns.heatmap(df, annot=True, fmt="g", cmap=cmap1, mask=mask)

plt.xticks(rotation=-45)
if index == '1':
    plt.title("Energy Delay Product: Weight "+  index +" (Energy Efficiency)",fontsize= 20)
if index == '2':
    plt.title("Energy Delay Product: Weight "+  index +" (Balanced)",fontsize= 20)
if index == '3':
    plt.title("Energy Delay Product: Weight "+  index +" (Performance Efficiency)",fontsize= 20)
    
plt.savefig('Normalized_Results_EDP_'+  index +'_HeatMap_Logarithmic_Function.png')

plt.show()


# In[46]:


get_ipython().magic(u'pinfo df')

