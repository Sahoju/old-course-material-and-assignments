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

jussi = Student("Jussi", 24, "L4929")
jussi2 = Student("Jussi", 19, "G8194")
print(jussi.name, jussi.age, jussi.student_id)
jussi.add_course("Script Programming")
jussi.add_course("UI Ohjelmointi")
jussi2.add_course("Mediaprojekti")
jussi2.add_course("Digitaalinen video ja audio")
jussi.list_courses()
jussi2.list_courses()
