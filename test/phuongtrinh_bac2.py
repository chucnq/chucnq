print('Giải phương trình bậc 2')

# mệnh đề sau while là đúng thì chạy vô hạn, sai False không chạy
while True:
    a = float(input('Nhập a: '))
    b = float(input('Nhập b: '))
    c = float(input('Nhập c: '))

    if a < 0:
        print('a phải lớn hơn 0')
    else:
        delta = float(b**2 - 4*a*c)
        if delta < 0:
            print('Phương trình vô nghiệm!')
        elif delta == 0:
            print('Phương trình có nghiệm kép: ')
            x0 = -b/a_2
            print('x = ',x0)
        else:
            delta_sqrt = delta ** 0.5
            a_2 = 2*a
            x1 = (-b + delta_sqrt)/(a_2)
            x2 = (-b - delta_sqrt)/(a_2)
            # print('Phương trình có hai nghiệm là : ')
            # print('Số thứ nhất: ',x1)
            # print('Số thứ hai: ',x2)
            #hoặc
            print('Phương trình có 2 nghiệm: {0} và {1}'.format(x1,x2))

# Lệnh format giúp code đỡ messy
# print('Tôi là chim bé , 22 tuổi, no gấu')
name = "chim bé"
age = 22
_fn = 1

print('Tôi là {0},{1} tuổi, {2} gấu'.format(name,age,_fn))