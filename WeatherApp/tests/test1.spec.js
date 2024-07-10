import { test, expect } from '@playwright/test';

test('has title', async ({ page }) => {
  await page.goto('https://www.weather.gov/');

  // Expect the title to contain "National Weather Service".
  await expect(page).toHaveTitle(/National Weather Service/);
});

test('has safety information link', async ({ page }) => {
  await page.goto('https://www.weather.gov/');

  // Expect the safety information link to be visible.
  await expect(page).toHaveSelector('a[href="/http://www.weather.gov/safety"]');
});

test('has news link', async ({ page }) => {
  await page.goto('https://www.weather.gov/');

  // Expect the news link to be visible.
  await expect(page).toHaveSelector('a[href="/http://www.weather.gov/news/"]');
});




