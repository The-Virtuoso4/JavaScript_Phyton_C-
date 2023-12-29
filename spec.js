const webdriver = require('selenium-webdriver');
driver =  new webdriver.Builder().forBrowser('chrome').build();
const By = webdriver.By

 async function testRun(){
 await driver.get('https://shafa.ua/');
 let textBox = await driver.findElement(By.xpath('/html/body/div[2]/div[2]/div[1]/div/div[1]/div/div/div[2]/div/form/div/input'));
 await textBox.sendKeys('Футболки');
 await driver.sleep(1)
 let submitButton = await driver.findElement(By.xpath('/html/body/div[2]/div[2]/div[1]/div/div[1]/div/div/div[2]/div/form/button'));
 await submitButton.click();

 let catalog = await driver.findElement(By.xpath('/html/body/div[1]/div[2]/div[3]/div/div/div[2]/div/div[2]/div/div[2]/a'));
 await catalog.click();

 let reset = await driver.findElement(By.xpath('/html/body/div[1]/div[2]/div[3]/div/div/div[2]/div/div[4]/div[1]/a'));
 await reset.click();
}
testRun();

