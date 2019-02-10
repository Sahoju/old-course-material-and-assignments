import sys

class Student:

    def __init__(self, name, age, student_id):
        self.name = name
        self.age = age
        self.student_id = student_id
        self.courses = []

    def add_course(self, course):
        self.courses.append(course)

    def list_courses(self):
        for course in self.courses:
            print(course)
        print('')

def read_student_data(path):
    students = []
    f = open(path, "r")
    i = 1
    for line in f:
        l = line.strip()
        temp = l.split(';')
        temp2 = temp[3].split(',')

        students.append(Student(temp[0], temp[1], temp[2]))
        for course in temp2:
            students[-1].add_course(course)
        
    return students

def filter_by_course(students, coursefilter):
    filtered_students = []
    for student in students:
        for course in student.courses:
            if(course == coursefilter):
                filtered_students.append(student)
    return filtered_students

students = read_student_data("student-data.txt")
for student in students:
    print("{0}, {1}, {2}".format(student.name, student.age, student.student_id))
    student.list_courses()

filtered_students = filter_by_course(students, "Johtaminen")
for student in filtered_students:
    print("{0}, {1}, {2}".format(student.name, student.age, student.student_id))
