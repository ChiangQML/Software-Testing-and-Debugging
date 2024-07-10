const { chromium } = require('playwright');

describe('Weather.gov UI Tests', () => {
  let browser;
  let page;

  beforeAll(async () => {
    browser = await chromium.launch();
    page = await browser.newPage();
    await page.goto('https://www.weather.gov/');
  });

  afterAll(async () => {
    await browser.close();
  });

  test('has correct title', async () => {
    const title = await page.title();
    expect(title).toContain('National Weather Service');
  });
});
