import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component';
import { NavComponent } from './nav/nav.component';
import { HomeComponent } from './home/home.component';
import { ErrorInteceptorProvider } from './_services/error.interceptor';


@NgModule({
   declarations: [
      AppComponent,
      ValueComponent,
      NavComponent,
      HomeComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule
   ],
   providers: [
      ErrorInteceptorProvider
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }

