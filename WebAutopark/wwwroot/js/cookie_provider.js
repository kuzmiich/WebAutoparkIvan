﻿export function setCookie(name, value, date, path = "/", domain = "", secure = true) {
    let cookieString = `${name}=${escape(value)}`;

    if (date) {
        cookieString += `; expires=${date.toGMTString()}`;
    }
    if (path) {
        cookieString += `; path=${escape(path)}`;
    }
    if (domain) {
        cookieString += `; domain=${escape(domain)}`;
    }
    if (secure) {
        cookieString += "; secure";
    }

    document.cookie = cookieString;
}

export function deleteCookie(cookieName) {
    let cookieDate = new Date();  // Текущая дата и время
    cookieDate.setTime(cookieDate.getTime() - 1);
    document.cookie = `${cookieName}=; expires=${cookieDate.toGMTString()}`;
}

export function getCookie(cookieName) {
    let results = document.cookie.match(`(^|;) ?${cookieName}=([^;]*)(;|$)`);

    return results ? unescape(results[2]) : null;
}