import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';

import { routes } from './app.routes';
import { provideHttpClient } from '@angular/common/http';

// remem that appConfig is a  plain JavaScript object that matches the ApplciationConfig type 
//it is not a function or a property . the object is exported so it can be imported and used elsewhere like in the main.ts file for the boot strapping the Angular application
export const appConfig: ApplicationConfig = {
  providers: [
    provideRouter(routes),
    provideHttpClient(),
  ]
};
  