<template>
    <DxDataGrid :data-source="dataSource" key-expr="ID"
                :visible="true"
                :show-borders="true"
                :columns="columns">
    </DxDataGrid>
</template>
<script>
    import
    {
        DxDataGrid,
        DxColumn
    } from 'devextreme-vue/data-grid';

    import { defineComponent } from 'vue';

    const customers = [{
        ID: 1,
        CompanyName: 'Super Mart of the West',
        Address: '702 SW 8th Street',
        City: 'Bentonville',
        State: 'Arkansas',
        Zipcode: 72716,
        Phone: '(800) 555-2797',
        Fax: '(800) 555-2171',
        Website: 'http://www.nowebsitesupermart.com',
    }, {
        ID: 2,
        CompanyName: 'Electronics Depot',
        Address: '2455 Paces Ferry Road NW',
        City: 'Atlanta',
        State: 'Georgia',
        Zipcode: 30339,
        Phone: '(800) 595-3232',
        Fax: '(800) 595-3231',
        Website: 'http://www.nowebsitedepot.com',
    }, {
        ID: 3,
        CompanyName: 'K&S Music',
        Address: '1000 Nicllet Mall',
        City: 'Minneapolis',
        State: 'Minnesota',
        Zipcode: 55403,
        Phone: '(612) 304-6073',
        Fax: '(612) 304-6074',
        Website: 'http://www.nowebsitemusic.com',
    }];


    export default defineComponent({
        name: "main-component",
        components: {
            DxDataGrid,
            DxColumn,
        },
        data() {
            return {
                dataSource: customers,
                columns: [
                    {
                        dataField: 'id',
                        caption: 'ID',
                        allowEditing: false,
                        allowSorting: true
                    },
                    {
                        dataField: 'CompanyName',
                        caption: 'Company',
                        allowEditing: true,
                        allowSorting: true
                    },
                    {
                        dataField: 'Address',
                        caption: 'Address',
                        allowEditing: true,
                        allowSorting: false
                    },
                    {
                        dataField: 'City',
                        caption: 'City',
                        allowEditing: true,
                        allowSorting: false
                    },
                    {
                        dataField: 'State',
                        caption: 'State',
                        allowEditing: true,
                        allowSorting: false
                    }
                ],
            };
        },
    });
</script>