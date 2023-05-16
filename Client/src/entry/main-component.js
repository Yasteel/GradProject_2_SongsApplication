import { defineCustomElement } from "vue";
import Component from "../components/main-component.vue";
window.customElements.define('main-component', defineCustomElement(Component));