---
slug: /
sidebar_position: 1
---

import CodeBlock from '@theme/CodeBlock';
import Schema from "@site/static/schemas/FIDO.schema.json";
import JSONSchemaViewer from "@theme/JSONSchemaViewer";

# FIDO Specification

<JSONSchemaViewer schema={ Schema } />

# Source :

<CodeBlock language="json">{JSON.stringify(Schema, null, 2)}</CodeBlock>