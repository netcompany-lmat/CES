import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from '../exampleFiles/counter/counter.component';
import { CityTextBox } from './components/city-textbox/city-textbox.component'
import { FetchDataComponent } from '../exampleFiles/fetch-data/fetch-data.component';
import { NgbModule, NgbToast } from '@ng-bootstrap/ng-bootstrap';
import { Dropdown } from './components/dropdown/dropdown.component';
import { CommonModule } from '@angular/common';
import { RoutesTable } from './components/routes-table/routes-table.component';
import { NgbdToastGlobal } from './components/toast-global/toast-global.component';
import { ToastsContainer } from './components/toasts-container/toast-container.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    CityTextBox,
    Dropdown,
    ToastsContainer,
    NgbdToastGlobal,
    RoutesTable
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    NgbModule,
    CommonModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent, NgbToast]
})
export class AppModule { }
