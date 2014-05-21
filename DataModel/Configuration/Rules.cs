namespace ZabbixApi.DataModel.Configuration
{
    public class Rules
    {
        /// <summary>
        /// Rules on how to import applications.
        /// Supported parameters:
        /// createMissing - (boolean) if set to true, new applications will be created;
        /// default:
        /// false;
        /// updateExisting - (boolean) if set to true, existing applications will be updated;
        /// default:
        /// false.
        /// </summary>
        public object applications;

        /// <summary>
        /// Rules on how to import LLD rules.
        /// Supported parameters:
        /// createMissing - (boolean) if set to true, new LLD rules will be created;
        /// default:
        /// false;
        /// updateExisting - (boolean) if set to true, existing LLD rules will be updated;
        /// default:
        /// false.
        /// </summary>
        public object discoveryRules;

        /// <summary>
        /// Rules on how to import graphs.
        /// Supported parameters:
        /// createMissing - (boolean) if set to true, new graphs will be created;
        /// default:
        /// false;
        /// updateExisting - (boolean) if set to true, existing graphs will be updated;
        /// default:
        /// false.
        /// </summary>
        public object graphs;

        /// <summary>
        /// Rules on how to import host groups.
        /// Supported parameters:
        /// createMissing - (boolean) if set to true, new host groups will be created;
        /// default:
        /// false.
        /// </summary>
        public object groups;

        /// <summary>
        /// Rules on how to import hosts.
        /// Supported parameters:
        /// createMissing - (boolean) if set to true, new hosts will be created;
        /// default:
        /// false;
        /// updateExisting - (boolean) if set to true, existing hosts will be updated;
        /// default:
        /// false.
        /// </summary>
        public object hosts;

        /// <summary>
        /// Rules on how to import images.
        /// Supported parameters:
        /// createMissing - (boolean) if set to true, new images will be created;
        /// default:
        /// false;
        /// updateExisting - (boolean) if set to true, existing images will be updated;
        /// default:
        /// false.
        /// </summary>
        public object images;

        /// <summary>
        /// Rules on how to import items.
        /// Supported parameters:
        /// createMissing - (boolean) if set to true, new items will be created;
        /// default:
        /// false;
        /// updateExisting - (boolean) if set to true, existing items will be updated;
        /// default:
        /// false.
        /// </summary>
        public object items;

        /// <summary>
        /// Rules on how to import maps.
        /// Supported parameters:
        /// createMissing - (boolean) if set to true, new maps will be created;
        /// default:
        /// false;
        /// updateExisting - (boolean) if set to true, existing maps will be updated;
        /// default:
        /// false.
        /// </summary>
        public object maps;

        /// <summary>
        /// Rules on how to import screens.
        /// Supported parameters:
        /// createMissing - (boolean) if set to true, new screens will be created;
        /// default:
        /// false;
        /// updateExisting - (boolean) if set to true, existing screens will be updated;
        /// default:
        /// false.
        /// </summary>
        public object screens;

        /// <summary>
        /// Rules on how to import template links.
        /// Supported parameters:
        /// createMissing - (boolean) if set to true, new links between templates and host will be created;
        /// default:
        /// false.
        /// </summary>
        public object templateLinkage;

        /// <summary>
        /// Rules on how to import templates.
        /// Supported parameters:
        /// createMissing - (boolean) if set to true, new templates will be created;
        /// default:
        /// false;
        /// updateExisting - (boolean) if set to true, existing templates will be updated;
        /// default:
        /// false.
        /// </summary>
        public object templates;

        /// <summary>
        /// Rules on how to import template screens.
        /// Supported parameters:
        /// createMissing - (boolean) if set to true, new template screens will be created;
        /// default:
        /// false;
        /// updateExisting - (boolean) if set to true, existing template screens will be updated;
        /// default:
        /// false.
        /// </summary>
        public object templateScreens;

        /// <summary>
        /// Rules on how to import triggers.
        /// Supported parameters:
        /// createMissing - (boolean) if set to true, new triggers will be created;
        /// default:
        /// false;
        /// updateExisting - (boolean) if set to true, existing triggers will be updated;
        /// default:
        /// false.
        /// </summary>
        public object triggers;
    }
}