import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgxsModule } from "@ngxs/store";
import { NgxsLoggerPluginModule } from "@ngxs/logger-plugin";
import { NgxsStoragePluginModule } from "@ngxs/storage-plugin";
import { NgxsReduxDevtoolsPluginModule } from "@ngxs/devtools-plugin";
import { NgxsRouterPluginModule } from "@ngxs/router-plugin";
import { NgxsEmitPluginModule } from "@ngxs-labs/emitter";
import { NgxsDispatchPluginModule } from "@ngxs-labs/dispatch-decorator";


/**
 * Module that provides application wide persistence features and functionality
 */
@NgModule({
  imports: [
    CommonModule,
    NgxsModule.forRoot(),
    NgxsLoggerPluginModule.forRoot(),
    NgxsStoragePluginModule.forRoot(),
    NgxsReduxDevtoolsPluginModule.forRoot(),
    NgxsRouterPluginModule.forRoot(),
    NgxsEmitPluginModule.forRoot(),
    NgxsDispatchPluginModule.forRoot()
  ],
  exports: [
    NgxsModule,
    NgxsLoggerPluginModule,
    NgxsStoragePluginModule,
    NgxsReduxDevtoolsPluginModule,
    NgxsRouterPluginModule,
    NgxsEmitPluginModule,
    NgxsDispatchPluginModule
  ]
})
export class AppStateModule { }
