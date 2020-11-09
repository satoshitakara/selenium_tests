import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { GymMembershipFormComponent } from './forms/gym-membership-form/gym-membership-form.component';
import { ReasearchFormComponent } from './forms/reasearch-form/reasearch-form.component';
import { TrainingFormComponent } from './forms/training-form/training-form.component';
import { RoommateFormComponent } from './forms/roommate-form/roommate-form.component';
import { RegistrationFormComponent } from './forms/registration-form/registration-form.component';
import { LoginFormComponent } from './forms/login-form/login-form.component';
import { SignUpFormComponent } from './forms/sign-up-form/sign-up-form.component';
import { CreateAccountFormComponent } from './forms/create-account-form/create-account-form.component';
import { EducationalRegistrationFormComponent } from './forms/educational-registration-form/educational-registration-form.component';
import { RunningRegistrationFormComponent } from './forms/running-registration-form/running-registration-form.component';
import { VolunteerSignupFormComponent } from './forms/volunteer-signup-form/volunteer-signup-form.component';
import { CampRegistrationFormComponent } from './forms/camp-registration-form/camp-registration-form.component';
import { NewMemberRegistrationFormComponent } from './forms/new-member-registration-form/new-member-registration-form.component';
import { ContactUsFormComponent } from './forms/contact-us-form/contact-us-form.component';
import { NewContactUsFormComponent } from './forms/new-contact-us-form/new-contact-us-form.component';
import { FeedbackFormComponent } from './forms/feedback-form/feedback-form.component';
import { WebsiteFeedbackFormComponent } from './forms/website-feedback-form/website-feedback-form.component';
import { CustomerFeedbackFormComponent } from './forms/customer-feedback-form/customer-feedback-form.component';
import { RestaurantFeedbackFormComponent } from './forms/restaurant-feedback-form/restaurant-feedback-form.component';
import { HotelFeedbackFormComponent } from './forms/hotel-feedback-form/hotel-feedback-form.component';
import { BankCustomerFeedbackFormComponent } from './forms/bank-customer-feedback-form/bank-customer-feedback-form.component';
import { WebsiteRatingFormComponent } from './forms/website-rating-form/website-rating-form.component';
import { SeminarEvaluationFormComponent } from './forms/seminar-evaluation-form/seminar-evaluation-form.component';
import { CourseEvaluationFormComponent } from './forms/course-evaluation-form/course-evaluation-form.component';
import { YogaFormComponent } from './forms/yoga-form/yoga-form.component';
import { DonationFormComponent } from './forms/donation-form/donation-form.component';
import { BabysitterFormComponent } from './forms/babysitter-form/babysitter-form.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavMenuComponent,
    GymMembershipFormComponent,
    ReasearchFormComponent,
    TrainingFormComponent,
    RoommateFormComponent,
    RegistrationFormComponent,
    LoginFormComponent,
    SignUpFormComponent,
    CreateAccountFormComponent,
    EducationalRegistrationFormComponent,
    RunningRegistrationFormComponent,
    VolunteerSignupFormComponent,
    CampRegistrationFormComponent,
    NewMemberRegistrationFormComponent,
    ContactUsFormComponent,
    NewContactUsFormComponent,
    FeedbackFormComponent,
    WebsiteFeedbackFormComponent,
    CustomerFeedbackFormComponent,
    RestaurantFeedbackFormComponent,
    HotelFeedbackFormComponent,
    BankCustomerFeedbackFormComponent,
    WebsiteRatingFormComponent,
    SeminarEvaluationFormComponent,
    CourseEvaluationFormComponent,
    YogaFormComponent,
    DonationFormComponent,
    BabysitterFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
