/*
Copyright © 2022 Annpoint, s.r.o.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

-------------------------------------------------------------------------

NOTE: Requires the following acknowledgement (see also NOTICE):
This software includes DayPilot (https://www.daypilot.org).
*/

type GlobalDate = Date;

export module DayPilot {

    export class CalendarPropsAndEvents {
        backendUrl?: string;
        businessBeginsHour?: number;
        businessEndsHour?: number;
        cellHeight?: number;
        columnMarginRight?: number;
        days?: number;
        doubleClickTimeout?: number;
        durationBarVisible?: boolean;
        eventClickHandling?: "Enabled" | "Disabled" | "CallBack" | "Edit" | "Select" | "ContextMenu" | "Bubble";
        eventDeleteHandling?: "Update" | "Disabled" | "CallBack";
        eventMoveHandling?: "Update" | "CallBack" | "Notify" | "Disabled";
        eventResizeHandling?: "Update" | "CallBack" | "Notify" | "Disabled";
        headerHeight?: number;
        height?: number;
        heightSpec?: "BusinessHours" | "BusinessHoursNoScroll" | "Fixed" | "Full" | "Parent100Pct";
        hideUntilInit?: boolean;
        hourWidth?: number;
        initScrollPos?: number;
        loadingLabelText?: string;
        loadingLabelHtml?: string;
        loadingLabelVisible?: boolean;
        locale?: string;
        showToolTip?: boolean;
        startDate?: DayPilot.Date | string;
        theme?: string;
        timeFormat?: "Auto" | "Clock12Hours" | "Clock24Hours";
        timeRangeSelectedHandling?: "Enabled" | "Disabled" | "CallBack";
        viewType?: "Day" | "Days" | "Week" | "WorkWeek";
        visible?: boolean;
        // weekStarts?: "Auto" | number;
        xssProtection?: "Enabled" | "Disabled";

        onEventClick?: EventHandler<CalendarEventClickArgs>;
        onEventClicked?: EventHandler<CalendarEventClickedArgs>;
        onEventDelete?: EventHandler<CalendarEventDeleteArgs>;
        onEventDeleted?: EventHandler<CalendarEventDeletedArgs>;
        onEventMove?: EventHandler<CalendarEventMoveArgs>;
        onEventMoved?: EventHandler<CalendarEventMovedArgs>;
        onEventResize?: EventHandler<CalendarEventResizeArgs>;
        onEventResized?: EventHandler<CalendarEventResizedArgs>;
        onTimeRangeSelect?: EventHandler<CalendarTimeRangeSelectArgs>;
        onTimeRangeSelected?: EventHandler<CalendarTimeRangeSelectedArgs>;

    }

    export class CalendarConfig extends CalendarPropsAndEvents {
        events?: EventData[];
    }

    export class Calendar extends CalendarPropsAndEvents {
        v: string;
        events: {
            list: EventData[];
            add(e: DayPilot.Event | EventData): void;
            find(id: string): DayPilot.Event;
            load(url: string,
                 success: (args: { data: any; preventDefault(): void; }) => void,
                 error: (args: { request: XMLHttpRequest, exception: any; }) => void
            ): void;
            remove(e: DayPilot.Event): void;
            remove(id: EventId): void;
            update(e: DayPilot.Event | EventData): void;
        };

        constructor(id: string | HTMLElement, options?: CalendarConfig);

        clearSelection(): void;

        dispose(): void;

        getSelection(): DayPilot.Selection;

        hide(): void;

        init(): void;

        show(): void;

        update(options?: CalendarConfig): void;

        visibleStart(): DayPilot.Date;

        visibleEnd(): DayPilot.Date;

    }


    export interface CalendarEventClickArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Calendar;
        readonly ctrl: boolean;
        readonly meta: boolean;
        readonly originalEvent: MouseEvent;
        preventDefault(): void;
    }


    export interface CalendarEventClickedArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Calendar;
        readonly ctrl: boolean;
        readonly meta: boolean;
        readonly originalEvent: MouseEvent;
    }


    export interface CalendarEventDeleteArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Calendar;
        preventDefault(): void;
    }


    export interface CalendarEventDeletedArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Calendar;
    }


    export interface CalendarEventMoveArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Calendar;
        readonly newStart: DayPilot.Date;
        readonly newEnd: DayPilot.Date;
        readonly ctrl: boolean;
        readonly shift: boolean;

        preventDefault(): void;
    }


    export interface CalendarEventMovedArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Calendar;
        readonly newStart: DayPilot.Date;
        readonly newEnd: DayPilot.Date;
        readonly ctrl: boolean;
        readonly shift: boolean;
    }


    export interface CalendarEventResizeArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Calendar;
        readonly newStart: DayPilot.Date;
        readonly newEnd: DayPilot.Date;

        preventDefault(): void;
    }


    export interface CalendarEventResizedArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Calendar;
        readonly newStart: DayPilot.Date;
        readonly newEnd: DayPilot.Date;
    }


    export interface CalendarTimeRangeSelectArgs {
        readonly start: DayPilot.Date;
        readonly end: DayPilot.Date;
        readonly control: DayPilot.Calendar;
        preventDefault(): void;
    }


    export interface CalendarTimeRangeSelectedArgs {
        readonly start: DayPilot.Date;
        readonly end: DayPilot.Date;
        readonly control: DayPilot.Calendar;
    }

    export class MonthPropsAndEvents {
        backendUrl?: string;
        cellHeaderHeight?: number;
        cellHeight?: number;
        eventClickHandling?: "Enabled" | "Disabled" | "CallBack" | "Select" | "ContextMenu" | "Bubble";
        eventHeight?: number;
        eventDeleteHandling?: "Update" | "Disabled";
        eventMoveHandling?: "Update" | "CallBack" | "Notify" | "Disabled";
        eventResizeHandling?: "Update" | "CallBack" | "Notify" | "Disabled";
        headerHeight?: number;
        hideUntilInit?: boolean;
        lineSpace?: number;
        locale?: string;
        showToolTip?: boolean;
        startDate?: DayPilot.Date | string;
        theme?: string;
        timeRangeSelectedHandling?: "Enabled" | "Disabled" | "CallBack";
        visible?: boolean;
        weekStarts?: number;
        width?: string;
        xssProtection?: "Enabled" | "Disabled";

        onCellHeaderClick?: EventHandler<MonthCellHeaderClickArgs>;
        onCellHeaderClicked?: EventHandler<MonthCellHeaderClickedArgs>;
        onEventClick?: EventHandler<MonthEventClickArgs>;
        onEventClicked?: EventHandler<MonthEventClickedArgs>;
        onEventDelete?: EventHandler<MonthEventDeleteArgs>;
        onEventDeleted?: EventHandler<MonthEventDeletedArgs>;
        onEventMove?: EventHandler<MonthEventMoveArgs>;
        onEventMoved?: EventHandler<MonthEventMovedArgs>;
        onEventResize?: EventHandler<MonthEventResizeArgs>;
        onEventResized?: EventHandler<MonthEventResizedArgs>;
        onTimeRangeSelect?: EventHandler<MonthTimeRangeSelectArgs>;
        onTimeRangeSelected?: EventHandler<MonthTimeRangeSelectedArgs>;
    }

    export class MonthConfig extends MonthPropsAndEvents {
        events?: EventData;
    }

    export class Month extends MonthPropsAndEvents {
        v: string;
        events: {
            list: EventData[];
            add(e: DayPilot.Event | EventData): void;
            load(url: string,
                 success: (args: { data: any; preventDefault(): void; }) => void,
                 error: (args: { request: XMLHttpRequest, exception: any; }) => void
            ): void;
            remove(e: DayPilot.Event): void;
            update(e: DayPilot.Event): void;
        };

        constructor(id: string | HTMLElement, options?: MonthConfig);

        clearSelection(): void;

        dispose(): void;

        init(): void;

        show(): void;

        hide(): void;

        update(options?: MonthConfig): void;

        visibleStart(): DayPilot.Date;

        visibleEnd(): DayPilot.Date;

    }


    export interface MonthCellHeaderClickArgs {
        readonly control: DayPilot.Month;
        readonly start: DayPilot.Date;
        readonly end: DayPilot.Date;
        preventDefault(): void;
    }

    export interface MonthCellHeaderClickedArgs {
        readonly control: DayPilot.Month;
        readonly start: DayPilot.Date;
        readonly end: DayPilot.Date;
    }

    export interface MonthEventClickArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Month;
        readonly div: HTMLElement;
        readonly originalEvent: MouseEvent;
        readonly meta: boolean;
        readonly ctrl: boolean;
        preventDefault(): void;
    }


    export interface MonthEventClickedArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Month;
        readonly div: HTMLElement;
        readonly originalEvent: MouseEvent;
        readonly meta: boolean;
        readonly ctrl: boolean;
    }

    export interface MonthEventDeleteArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Month;
        preventDefault(): void;
    }

    export interface MonthEventDeletedArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Month;
    }

    export interface MonthEventMoveArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Month;
        readonly newStart: DayPilot.Date;
        readonly newEnd: DayPilot.Date;
        readonly ctrl: boolean;
        readonly shift: boolean;
        preventDefault(): void;
    }


    export interface MonthEventMovedArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Month;
        readonly newStart: DayPilot.Date;
        readonly newEnd: DayPilot.Date;
        readonly ctrl: boolean;
        readonly shift: boolean;
    }


    export interface MonthEventResizeArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Month;
        readonly newStart: DayPilot.Date;
        readonly newEnd: DayPilot.Date;
        preventDefault(): void;
    }


    export interface MonthEventResizedArgs {
        readonly e: DayPilot.Event;
        readonly control: DayPilot.Month;
        readonly newStart: DayPilot.Date;
        readonly newEnd: DayPilot.Date;
    }


    export interface MonthTimeRangeSelectArgs {
        readonly control: DayPilot.Month;
        readonly start: DayPilot.Date;
        readonly end: DayPilot.Date;
        preventDefault(): void;
    }


    export interface MonthTimeRangeSelectedArgs {
        readonly control: DayPilot.Month;
        readonly start: DayPilot.Date;
        readonly end: DayPilot.Date;
    }

    export class NavigatorPropsAndEvents {
        cellHeight?: number;
        cellWidth?: number;
        command?: string;
        dayHeaderHeight?: number;
        freeHandSelectionEnabled?: boolean;
        locale?: string;
        orientation?: "Vertical" | "Horizontal";
        rowsPerMonth?: "Auto" | "Six";
        selectionDay?: DayPilot.Date;
        selectionEnd?: DayPilot.Date;
        selectionStart?: DayPilot.Date;
        selectMode?: "Day" | "Week" | "Month" | "None";
        showMonths?: number;
        showWeekNumbers?: boolean;
        skipMonths?: number;
        startDate?: DayPilot.Date | string;
        theme?: string;
        titleHeight?: number;
        weekStarts?: "Auto" | number;
        weekNumberAlgorithm?: "Auto" | "US" | "ISO8601";
        timeRangeSelectedHandling?: "Bind" | "None";
        visibleRangeChangedHandling?: "Enabled" | "Disabled" | "CallBack";

        onBeforeCellRender?: EventHandler<NavigatorBeforeCellRenderArgs>;
        onTimeRangeSelect?: EventHandler<NavigatorTimeRangeSelectArgs>;
        onTimeRangeSelected?: EventHandler<NavigatorTimeRangeSelectedArgs>;
        onVisibleRangeChange?: EventHandler<NavigatorVisibleRangeChangeArgs>;
        onVisibleRangeChanged?: EventHandler<NavigatorVisibleRangeChangedArgs>;
    }

    export class NavigatorConfig extends NavigatorPropsAndEvents {
        events?: EventData[];
    }

    export class Navigator extends NavigatorPropsAndEvents {
        v: string;
        events: {
            list: EventDataShort[];
        };

        constructor(id: string | HTMLElement, options?: NavigatorConfig);

        init(): void;

        dispose(): void;

        update(options?: NavigatorConfig): void;

        select(date: DayPilot.Date | string): void;

        hide(): void;

        show(): void;

        visibleEnd(): DayPilot.Date;

        visibleStart(): DayPilot.Date;
    }

    interface NavigatorBeforeCellRenderArgs {
        readonly cell: {
            readonly day: DayPilot.Date;
            readonly isCurrentMonth: boolean;
            readonly isToday: boolean;
            readonly isWeekend: boolean;
            html: string;
            cssClass: string;
        };
    }

    interface NavigatorTimeRangeSelectArgs {
        readonly start: DayPilot.Date;
        readonly end: DayPilot.Date;
        readonly day: DayPilot.Date;
        readonly days: number;
        readonly mode: "Day" | "Week" | "Month" | "None" | "FreeHand";
        preventDefault(): void;
    }

    interface NavigatorTimeRangeSelectedArgs {
        readonly start: DayPilot.Date;
        readonly end: DayPilot.Date;
        readonly day: DayPilot.Date;
        readonly days: number;
        readonly mode: "Day" | "Week" | "Month" | "None" | "FreeHand";
    }

    interface NavigatorVisibleRangeChangeArgs {
        readonly start: DayPilot.Date;
        readonly end: DayPilot.Date;
        preventDefault(): void;
    }

    interface NavigatorVisibleRangeChangedArgs {
        readonly start: DayPilot.Date;
        readonly end: DayPilot.Date;
    }

    export class Locale {
        datePattern: string;
        dateTimePattern: string;
        dayNames: string[];
        dayNamesShort: string[];
        monthNames: string[];
        monthNamesShort: string[];
        timeFormat: "Clock12Hours" | "Clock24Hours";
        timePattern: string;
        weekStarts: number;

        constructor(id: string, properties: {
            dayNames: string[];
            dayNamesShort: string[];
            monthNames: string[];
            monthNamesShort: string[];
            timePattern: string;
            datePattern: string;
            dateTimePattern: string;
            timeFormat: "Clock12Hours" | "Clock24Hours";
            weekStarts: number;
        });

        static register(locale: DayPilot.Locale): void;
        static find(id: string): DayPilot.Locale;
    }

    export class Date {
        constructor(str?: string | DayPilot.Date);
        constructor(date: GlobalDate, isLocal?: boolean);

        addDays(days: number): DayPilot.Date;

        addHours(hours: number): DayPilot.Date;

        addMilliseconds(millis: number): DayPilot.Date;

        addMinutes(minutes: number): DayPilot.Date;

        addMonths(months: number): DayPilot.Date;

        addSeconds(seconds: number): DayPilot.Date;

        addTime(ticks: number): DayPilot.Date;
        addTime(duration: DayPilot.Duration): DayPilot.Date;

        addYears(years: number): DayPilot.Date;

        dayOfWeek(): number;

        dayOfWeekISO(): number;

        dayOfYear(): number;

        daysInMonth(): number;

        daysInYear(): number;

        equals(another: DayPilot.Date): boolean;

        firstDayOfMonth(): DayPilot.Date;

        firstDayOfWeek(locale?: string | DayPilot.Locale): DayPilot.Date;
        firstDayOfWeek(firstDayOfWeek?: number): DayPilot.Date;

        firstDayOfYear(): DayPilot.Date;

        getDatePart(): DayPilot.Date;

        getDay(): number;

        getDayOfWeek(): number;

        getYear(): number;

        getHours(): number;

        getMilliseconds(): number;

        getMinutes(): number;

        getMonth(): number;

        getSeconds(): number;

        getTime(): number;

        getTimePart(): number;

        getTotalTicks(): number;

        getYear(): number;

        lastDayOfMonth(): DayPilot.Date;

        toDate(): GlobalDate;

        toDateLocal(): GlobalDate;

        toString(pattern?: string, locale?: string | DayPilot.Locale): string;

        toStringSortable(): string;

        weekNumber(): number;

        weekNumberISO(): number;

        static fromYearMonthDay(year: number, month: number, day: number): DayPilot.Date;
        static parse(input: string, pattern: string, locale?: string | DayPilot.Locale): DayPilot.Date;
        static today(): DayPilot.Date;
        static now(): DayPilot.Date;
        static Cache: DayPilotDateCache;
    }

    export class DayPilotDateCache {
        static clear(): void;
    }

    export class Util {
        static overlaps(start1: DayPilot.Date, end1: DayPilot.Date, start2: DayPilot.Date, end2: DayPilot.Date): boolean;
        static overlaps(start1: number, end1: number, start2: number, end2: number): boolean;
        static escapeHtml(text: string): string;
    }

    export class Http {
        static get(url: string, options?: HttpGetOptions): Promise<HttpPromiseArgs>;
        static post(url: string, data?: object | string, options?: HttpPostOptions): Promise<HttpPromiseArgs>;
        static put(url: string, data?: object | string, options?: HttpPutOptions): Promise<HttpPromiseArgs>;
        static delete(url: string, options?: HttpDeleteOptions): Promise<HttpPromiseArgs>;
    }

    export interface HttpDeleteOptions {
        headers?: HttpHeaders;
    }

    export interface HttpGetOptions {
        headers?: HttpHeaders;
    }

    export interface HttpPostOptions {
        headers?: HttpHeaders;
        contentType?: string;
    }

    export interface HttpPutOptions {
        headers?: HttpHeaders;
        contentType?: string;
    }

    export interface HttpPromiseArgs {
        readonly data: any;
        readonly request: XMLHttpRequest;
    }

    export interface HttpHeaders {
        [header: string]: string;
    }

    export class Duration {

        ticks: number;

        constructor(ticks: number);

        constructor(start: DayPilot.Date | string, end: DayPilot.Date | string);

        toString(pattern?: string): string;

        totalMilliseconds(): number;

        totalSeconds(): number;

        totalMinutes(): number;

        totalHours(): number;

        totalDays(): number;

        milliseconds(): number;

        seconds(): number;

        minutes(): number;

        hours(): number;

        days(): number;

        add(d: DayPilot.Duration): DayPilot.Duration;

        static ofWeeks(i: number): DayPilot.Duration;

        static ofDays(i: number): DayPilot.Duration;

        static ofHours(i: number): DayPilot.Duration;

        static ofMinutes(i: number): DayPilot.Duration;

        static ofSeconds(i: number): DayPilot.Duration;

    }

    export class Event {
        data: any;

        constructor(data: EventData);

        start(): DayPilot.Date;
        start(newStart: DayPilot.Date): void;

        end(): DayPilot.Date;
        end(newEnd: DayPilot.Date): void;

        id(): EventId;

        text(): string;
        text(newText: string): void;

        resource(): string;
        resource(newResource: string): void;

        duration(): DayPilot.Duration;
    }

    export class Selection {
        start: DayPilot.Date;
        end: DayPilot.Date;
        resource: string;
    }

    export interface EventDataShort {
        start: string | DayPilot.Date;
        end: string | DayPilot.Date;
    }

    export interface EventData {
        start: string | DayPilot.Date;
        end: string | DayPilot.Date;
        id: EventId;
        text: string;
        resource?: ResourceId;

        backColor?: string;
        backImage?: string;
        backRepeat?: string;
        borderColor?: string;
        bubbleHtml?: string;
        clickDisabled?: boolean;
        cssClass?: string;
        deleteDisabled?: boolean;
        doubleClickDisabled?: boolean;
        fontColor?: string;
        hidden?: boolean;
        html?: string;
        line?: "dedicated" | number;
        moveDisabled?: boolean;
        resizeDisabled?: boolean;
        rightClickDisabled?: boolean;
        sort?: string[];
        tags?: any;
        toolTip?: string;

        // scheduler
        barBackColor?: string;
        barColor?: string;
        barHidden?: boolean;
        complete?: number;
        container?: number | string;
        height?: number;
        htmlLeft?: string;
        htmlRight?: string;
        moveVDisabled?: boolean;
        moveHDisabled?: boolean;

    }

    export function guid(): string;

    export interface EventHandler<T> {
        (args: T): void;
    }

    export type ResourceId = string | number;
    export type EventId = string | number;

    // modal

    export class ModalPropsAndEvents {
        autoFocus?: boolean;
        autoStretch?: boolean;
        autoStretchFirstLoadOnly?: boolean;
        container?: HTMLElement;
        disposeOnClose?: boolean;
        dragDrop?: boolean;
        focus?: string | { id: string, value: string | number };
        height?: number;
        left?: number;
        loadingHtml?: string;
        maxHeight?: number;
        scrollWithPage?: boolean;
        theme?: string;
        top?: number;
        useIframe?: boolean;
        width?: number;
        zIndex?: number;

        onClose?: EventHandler<ModalCloseArgs>;
        onClosed?: EventHandler<ModalClosedArgs>;
        onShow?: EventHandler<ModalShowArgs>;
    }

    export class ModalConfig extends ModalPropsAndEvents {
    }

    export class Modal extends ModalPropsAndEvents {
        constructor(options?: ModalConfig)

        close(result?: any): void;

        closeSerialized(): void;

        showHtml(html: string | HTMLElement): void;

        showUrl(url: string): void;

        stretch(): void;

        static close(): void;

        static opener(): void;

        static prompt(message: string, defaultValue?: string, options?: ModalPromptConfig): Promise<ModalClosedArgs>;

        static alert(message: string, options?: ModalAlertConfig): Promise<ModalClosedArgs>;

        static confirm(message: string, options?: ModalConfirmConfig): Promise<ModalClosedArgs>;

        static form(form?: ModalFormItem[], data?: any, options?: ModalFormConfig): Promise<ModalClosedArgs>;
    }

    export class ModalAlertConfig extends ModalConfig {
        okText?: string;
    }

    export class ModalConfirmConfig extends ModalConfig {
        okText?: string;
        cancelText?: string;
    }

    export class ModalPromptConfig extends ModalConfig {
        okText?: string;
        cancelText?: string;
    }

    export class ModalFormConfig extends ModalConfig {
        okText?: string;
        cancelText?: string;
        locale?: string;
        plugins?: any;
    }

    export interface ModalCloseArgs {
        canceled: boolean;
        result: any;
        backgroundClick: boolean;

        preventDefault(): void;
    }

    export interface ModalClosedArgs {
        canceled: boolean;
        result: any;
        backgroundClick: boolean;
    }

    export interface ModalShowArgs {
        root: Node
    }


    export interface ModalFormItem {
        id?: string;
        name?: string;
        type?: "text" | "date" | "searchable" | "select" | "radio" | "checkbox" | "table" | "title" | "image" | "html" | "textarea" | "scrollable" | string;
        image?: string;
        dateFormat?: string;
        disabled?: boolean;
        cssClass?: string;
        options?: ModalFormOption[];
        children?: ModalFormItem[];
        columns?: ModalFormTableColumns[];
        onValidate?: EventHandler<ModalFormItemValidationArgs>;
        onNewRow?: EventHandler<ModalFormTableItemNewRowArgs>;
        height?: number;
        text?: string;
        html?: string;
    }

    export interface ModalFormOption {
        id: string | number;
        name?: string;
        children?: ModalFormItem[];
    }

    export interface ModalFormTableColumns {
        id: string;
        name: string;
        type?: "text" | "number" | "select";
        options?: ModalFormOption[];
    }

    export interface ModalFormItemValidationArgs {
        value: any;
        result: any;
        valid: boolean;
        message: string;
    }

    export interface ModalFormTableItemNewRowArgs {
        value: any;
        result: any;
    }

}
