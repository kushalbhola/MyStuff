import os
import os.path
'''
Given a file name, returns a pair with the name and extension (hello.txt => [hello,txt])
'''
def split_name(file_name):
    return file_name.rsplit('.',1)

'''
Recursively renames files in subdirectories of base_directory so each file is named the subdirectory name plus the extension
WARNING! You will be very sad if you have multiple files with the same extension in any of those folders
'''
def rename_file(base_directory):

    #Get the folder name for base_directory (c:\users\foobar => foobar)
    directory_name = os.basename(base_directory)
    #List the files in base_directory
    for path in os.listdir(base_directory):
        old_name = base_directory + '/' + path
        #If the path points to a file, rename it directory name + '.' + extension
        if os.path.isfile(old_name):
           new_name = base_directory + '/' + directory_name + '.' + split_name(path)[1]
           if not os.path.exists(new_name):
                os.rename(old_name,new_name)
           else:
                print("ERROR:"+new_name+" exists")

        else:
           #If it's a subfolder, recursively call rename files on that directory.
           rename_files(old_name)