dictOfLists = {'will':['Rays of Light', 'Shade', 'Trace Awakens', 'Trace Rising'],
               'ahh':['Widespread Illness', 'The Tower', 'Blissful Death'],
               'strong':['Sinh', 'The Wight to Remain', 'Watcher & Defender'],
               'calm':['Movements', 'Otherworld', 'Where Are You?', 'Safe Haven']}

def add_to_list_in_dict(dictOfLists, listname, element):
    try:
        dictOfLists[listname].append(element)
    except KeyError:
        print("Given key does not exist in dict!")
    else:
        print(dictOfLists[listname])
    finally:
        print("Well, whatcha gonna do 'bout it?")

add_to_list_in_dict(dictOfLists, 'strong', 'Delirium')
add_to_list_in_dict(dictOfLists, 'argh', 'Amnesia')
