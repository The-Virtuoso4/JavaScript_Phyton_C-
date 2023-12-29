from idlelib import browser

from selenium import webdriver
import time
from selenium.webdriver.common.by import By

link ="https://rozetka.com.ua"
browser = webdriver.Chrome()
browser.get(link)


search_string = browser.find_element(By.XPATH, "/html/body/app-root/div/div/rz-header/rz-main-header/header/div/div/div/form/div/div[1]/input")
search_string.send_keys("Меблі")

button_search = browser.find_element(By.XPATH, "/html/body/app-root/div/div/rz-header/rz-main-header/header/div/div/div/form/button").click()

time.sleep(4)
check = browser.find_element(By.XPATH, "/html/body/app-root/div/div/rz-super-portal/div/main/section/div[1]/h1").text
check1 = "Меблі"
if check == check1:
    print("Тест пройшов успішно")
else:
    print("Тест пройшов неуспішно")

browser.quit()
